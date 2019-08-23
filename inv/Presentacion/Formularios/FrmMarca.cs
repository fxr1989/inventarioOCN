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
    public partial class FrmMarca : DevExpress.XtraEditors.XtraForm
    {
        private HelperFormulario helper;
        private IRepositorio<Marca> repositorio;
        private bool modificar;

        public FrmMarca()
        {
            InitializeComponent();
            helper = new HelperFormulario();
            repositorio = new Repositorio<Marca>();
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
                if (MessageBox.Show($"Seguro que desea guardar la Marca {txtMarca.Text.Trim()}", "Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Guardar();
                    CargarDatos();
                    return true;
                }
                return false;
            }            
            if (accion == EnumBotonAccion.Eliminar)
            {
                if (MessageBox.Show($"Seguro que desea eliminar la Marca {txtMarca.Text.Trim()}", "Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            var marca = repositorio.Obtener().ToList();                        
            gMarca.DataSource = marca;
            gvMarca.Columns["Productos"].Visible = false;
        }

        private void Guardar()
        {
            if (modificar)
            {
                var marcaId = int.Parse(txtMarca.Tag.ToString());
                var modificarMarca = repositorio.ObtenerUno(marcaId);
                var buscarMarca = repositorio.Obtener(marca => marca.Nombre.ToUpper() != modificarMarca.Nombre.ToUpper() && marca.Nombre.ToUpper() == txtMarca.Text.ToUpper());
                if (buscarMarca.Count() > 0) throw new ArgumentException($"La Marca {txtMarca.Text} ya existe");
                modificarMarca.Nombre = txtMarca.Text.Trim();
                repositorio.Actualizar(modificarMarca);
                repositorio.Guardar();
                MessageBox.Show("Se modifico correctamente", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var nuevaMarca = new Marca();
                nuevaMarca.Nombre = txtMarca.Text.Trim();
                var buscarMarca = repositorio.Obtener(marca => marca.Nombre.StartsWith(nuevaMarca.Nombre));
                if (buscarMarca.Count() > 0) throw new ArgumentException($"La Marca {nuevaMarca.Nombre} ya existe");
                repositorio.Agregar(nuevaMarca);
                repositorio.Guardar();
                MessageBox.Show("Se creo correctamente", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar()
        {
            var marcaId = int.Parse(txtMarca.Tag.ToString());
            var eliminar = repositorio.ObtenerUno(marcaId);
            if (eliminar == null) throw new ArgumentException("No se encontro la Marcar");
            repositorio.Eliminar(eliminar);
            repositorio.Guardar();
            MessageBox.Show("Se elimino correctamente", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvArea_Click(object sender, EventArgs e)
        {
            try
            {
                var marca = (Marca)gvMarca.GetFocusedRow();
                txtMarca.Tag = marca.MarcaID;
                txtMarca.Text = marca.Nombre;
                txtMarca.Focus();
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