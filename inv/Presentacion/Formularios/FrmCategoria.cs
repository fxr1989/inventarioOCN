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
    public partial class FrmCategoria : DevExpress.XtraEditors.XtraForm
    {
        private HelperFormulario helper;
        private IRepositorio<Categoria> categoriaRepositorio;
        private bool modificar;

        public FrmCategoria()
        {
            InitializeComponent();
            helper = new HelperFormulario();
            categoriaRepositorio = new Repositorio<Categoria>();
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
                if (MessageBox.Show($"Seguro que desea guardar la categoria {txtCategoria.Text.Trim()}", "Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Guardar();
                    CargarDatos();
                    return true;
                }
                return false;
            }            
            if (accion == EnumBotonAccion.Eliminar)
            {
                if (MessageBox.Show($"Seguro que desea eliminar la categoria {txtCategoria.Text.Trim()}", "Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            var areas = categoriaRepositorio.Obtener().ToList();                        
            gCategoria.DataSource = areas;
            gvCategoria.Columns["Productos"].Visible = false;
        }

        private void Guardar()
        {
            if (modificar)
            {
                var categoriaId = int.Parse(txtCategoria.Tag.ToString());
                var modificarCategoria = categoriaRepositorio.ObtenerUno(categoriaId);
                var buscarCategoria = categoriaRepositorio.Obtener(categoria => categoria.Nombre.ToUpper() != modificarCategoria.Nombre.ToUpper() && categoria.Nombre.ToUpper() == txtCategoria.Text.ToUpper());
                if (buscarCategoria.Count() > 0) throw new ArgumentException($"La categoria {txtCategoria.Text} ya existe");
                modificarCategoria.Nombre = txtCategoria.Text.Trim();
                categoriaRepositorio.Actualizar(modificarCategoria);
                categoriaRepositorio.Guardar();
                MessageBox.Show("Se modifico correctamente", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var nuevaCategoria = new Categoria();
                nuevaCategoria.Nombre = txtCategoria.Text.Trim();
                var buscarCategoria = categoriaRepositorio.Obtener(categoria => categoria.Nombre.StartsWith(nuevaCategoria.Nombre));
                if (buscarCategoria.Count() > 0) throw new ArgumentException($"La categoria {nuevaCategoria.Nombre} ya existe");
                categoriaRepositorio.Agregar(nuevaCategoria);
                categoriaRepositorio.Guardar();
                MessageBox.Show("Se creo correctamente", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar()
        {
            var categoriaId = int.Parse(txtCategoria.Tag.ToString());
            var categoriaEliminar = categoriaRepositorio.ObtenerUno(categoriaId);
            if (categoriaEliminar == null) throw new ArgumentException("No se encontro la categoria");
            categoriaRepositorio.Eliminar(categoriaEliminar);
            categoriaRepositorio.Guardar();
            MessageBox.Show("Se elimino correctamente", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvArea_Click(object sender, EventArgs e)
        {
            try
            {
                var datosArea = (Categoria)gvCategoria.GetFocusedRow();
                txtCategoria.Tag = datosArea.CategoriaID;
                txtCategoria.Text = datosArea.Nombre;
                txtCategoria.Focus();
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