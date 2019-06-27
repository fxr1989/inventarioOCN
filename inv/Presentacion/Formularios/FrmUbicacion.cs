using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Presentacion.Helper;
using Presentacion.Extensiones;
using Repositorios;
using Repositorios.Interface;
using Modelo;

namespace Presentacion.Formularios
{
    public partial class FrmUbicacion : DevExpress.XtraEditors.XtraForm
    {
        private HelperFormulario helper;
        private IRepositorio<Ubicacion> repositorio;
        private bool modificar;

        public FrmUbicacion()
        {
            InitializeComponent();
            helper = new HelperFormulario();
            repositorio = new Repositorio<Ubicacion>();
        }

        private void FrmArea_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BotonAccionClick(object sender, EventArgs e)
        {
            try
            {
                var accion = ((SimpleButton)sender).Accion();
                var ejecutarAccion = ValidarAccion(accion);
                if (ejecutarAccion)
                    helper.BotonesAccion(btnNuevo, btnModificar, btnEliminar, btnGuardar, btnCancelar, accion, gcDatosAreas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private bool ValidarAccion(EnumBotonAccion accion)
        {            
            if (accion == EnumBotonAccion.Nuevo)
                return true;
            if (accion == EnumBotonAccion.Modificar)
                return true;
            if (accion == EnumBotonAccion.Cancelar)
                return true;
            if (accion == EnumBotonAccion.Guardar)
            {
                if (MessageBox.Show($"Seguro que desea guardar la ubicacion {txtUbicacion.Text.Trim()}", "Ubicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Guardar();
                    CargarDatos();
                    return true;
                }
                return false;
            }            
            if (accion == EnumBotonAccion.Eliminar)
            {
                if (MessageBox.Show($"Seguro que desea eliminar la ubicacion {txtUbicacion.Text.Trim()}", "Ubicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Eliminar();
                    CargarDatos();
                    return true;
                }
                return false;
            }
            return false;
        }

        private void CargarDatos()
        {
            var areas = repositorio.Obtener().ToList();                        
            gUbicacion.DataSource = areas;            
        }

        private void Guardar()
        {
            if (modificar)
            {
                var ubicacionId = int.Parse(txtUbicacion.Tag.ToString());
                var modificarUbicacion = repositorio.ObtenerUno(ubicacionId);
                var buscarCategoria = repositorio.Obtener(categoria => categoria.Nombre.ToUpper() != modificarUbicacion.Nombre.ToUpper() && categoria.Nombre.ToUpper() == txtUbicacion.Text.ToUpper());
                if (buscarCategoria.Any()) throw new ArgumentException($"La ubicacion {txtUbicacion.Text} ya existe");
                modificarUbicacion.Nombre = txtUbicacion.Text.Trim();
                repositorio.Actualizar(modificarUbicacion);
                repositorio.Guardar();
                MessageBox.Show("Se modifico correctamente", "Ubicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var nuevaUbicacion = new Ubicacion();
                nuevaUbicacion.Nombre = txtUbicacion.Text.Trim();
                var buscarCategoria = repositorio.Obtener(categoria => categoria.Nombre.ToUpper() == nuevaUbicacion.Nombre.ToUpper());
                if (buscarCategoria.Any()) throw new ArgumentException($"La ubicacion {nuevaUbicacion.Nombre} ya existe");
                repositorio.Agregar(nuevaUbicacion);
                repositorio.Guardar();
                MessageBox.Show("Se creo correctamente", "Ubicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar()
        {
            var id = int.Parse(txtUbicacion.Tag.ToString());
            var eliminar = repositorio.ObtenerUno(id);
            if (eliminar == null) throw new ArgumentException("No se encontro la ubicación");
            repositorio.Eliminar(eliminar);
            repositorio.Guardar();
            MessageBox.Show("Se elimino correctamente", "Ubicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvArea_Click(object sender, EventArgs e)
        {
            try
            {
                var ubicacion = (Ubicacion)gvUbicacion.GetFocusedRow();
                txtUbicacion.Tag = ubicacion.UbicacionID;
                txtUbicacion.Text = ubicacion.Nombre;
                txtUbicacion.Focus();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                modificar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}