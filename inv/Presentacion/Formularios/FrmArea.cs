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
    public partial class FrmArea : DevExpress.XtraEditors.XtraForm
    {
        private HelperFormulario helper;
        private IRepositorio<Area> areaRepositorio;
        private bool modificar;

        public FrmArea()
        {
            InitializeComponent();
            helper = new HelperFormulario();
            areaRepositorio = new Repositorio<Area>();
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
                if (MessageBox.Show($"Seguro que desea guardar el area {txtArea.Text.Trim()}", "Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Guardar();
                    CargarDatos();
                    return true;
                }
                return false;
            }            
            if (accion == EnumBotonAccion.Eliminar)
            {
                if (MessageBox.Show($"Seguro que desea eliminar el area {txtArea.Text.Trim()}", "Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            var areas = areaRepositorio.Obtener().ToList();                        
            gArea.DataSource = areas;
            gvArea.Columns["Usuarios"].Visible = false;
        }

        private void Guardar()
        {
            if (modificar)
            {
                var areaId = int.Parse(txtArea.Tag.ToString());
                var modificarArea = areaRepositorio.ObtenerUno(areaId);
                var buscarArea = areaRepositorio.Obtener(area => area.Nombre.ToUpper() != modificarArea.Nombre.ToUpper() && area.Nombre.ToUpper() == txtArea.Text.ToUpper());
                if (buscarArea.Count() > 0) throw new ArgumentException($"El area {txtArea.Text} ya existe");
                modificarArea.Nombre = txtArea.Text.Trim();
                areaRepositorio.Actualizar(modificarArea);
                areaRepositorio.Guardar();                
            }
            else
            {
                var nuevaArea = new Area();
                nuevaArea.Nombre = txtArea.Text.Trim();
                var buscarArea = areaRepositorio.Obtener(area => area.Nombre.StartsWith(nuevaArea.Nombre));
                if (buscarArea.Count() > 0) throw new ArgumentException($"El area {nuevaArea.Nombre} ya existe");
                areaRepositorio.Agregar(nuevaArea);
                areaRepositorio.Guardar();
            }
        }

        private void Eliminar()
        {
            var areaId = int.Parse(txtArea.Tag.ToString());
            var areaElimianr = areaRepositorio.ObtenerUno(areaId);
            if (areaElimianr == null) throw new ArgumentException("No se encontro el area");
            areaRepositorio.Eliminar(areaElimianr);
            areaRepositorio.Guardar();
            MessageBox.Show("Se elimino correctamente", "Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvArea_Click(object sender, EventArgs e)
        {
            try
            {
                var datosArea = (Area)gvArea.GetFocusedRow();
                txtArea.Tag = datosArea.AreaID;
                txtArea.Text = datosArea.Nombre;
                txtArea.Focus();
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