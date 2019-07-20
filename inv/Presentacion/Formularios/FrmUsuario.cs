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
using Presentacion.Formularios.Buscadores;

namespace Presentacion.Formularios
{
    public partial class FrmUsuario : DevExpress.XtraEditors.XtraForm
    {
        private HelperFormulario helper;
        private IRepositorio<Usuario> repositorio;
        private bool modificar;

        public FrmUsuario()
        {
            InitializeComponent();
            helper = new HelperFormulario();
            repositorio = new Repositorio<Usuario>();
        }

        private void FrmArea_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonAccionClick(object sender, EventArgs e)
        {
            try
            {
                var accion = ((SimpleButton)sender).Accion();
                var ejecutarAccion = ValidarAccion(accion);
                if (ejecutarAccion)
                    helper.BotonesAccion(btnNuevo, btnModificar, btnEliminar, btnGuardar, btnCancelar, accion, gcDatosUsuario);
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
                if (MessageBox.Show($"Seguro que desea guardar el usuario {txtUsuario.Text.Trim()}", "Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Guardar();
                    CargarDatos();
                    return true;
                }
                return false;
            }            
            if (accion == EnumBotonAccion.Eliminar)
            {
                if (MessageBox.Show($"Seguro que desea eliminar el usaurio {txtUsuario.Text.Trim()}", "Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            var usuarios = (
                                from usuario in repositorio.Obtener()
                                select new { Usuario = usuario.NombreUsuario, usuario.Correo, usuario.Nombres, usuario.Apellidos, Area = usuario.area.Nombre, usuario.area }
                            ).ToList();
            gUsuario.DataSource = usuarios;
            gvUsuarios.Columns["area"].Visible = false;            
        }

        private void CargarCombobox()
        {
            var usuarios = (
                                from usuario in repositorio.Obtener()
                                select new { Usuario = usuario.NombreUsuario, usuario.Correo, usuario.Nombres, usuario.Apellidos, Area = usuario.area.Nombre, usuario.area }
                            ).ToList();
            gUsuario.DataSource = usuarios;
            gvUsuarios.Columns["area"].Visible = false;
        }

        private void Guardar()
        {
            if (modificar)
            {
                var usuarioId = int.Parse(txtUsuario.Tag.ToString());
                var modificarUsuario = repositorio.ObtenerUno(usuarioId);
                var buscarNombreUsuario = repositorio.Obtener(
                                                                    usuario =>  usuario.NombreUsuario.ToUpper() != modificarUsuario.NombreUsuario.ToUpper() && 
                                                                                    usuario.NombreUsuario.ToUpper() == txtUsuario.Text.ToUpper());
                if (buscarNombreUsuario.Any()) throw new ArgumentException($"Ya existe el nombre de usuario {txtUsuario.Text}");
                modificarUsuario.NombreUsuario = txtUsuario.Text.Trim();
                if (!string.IsNullOrEmpty(txtPassword.Text))
                    modificarUsuario.Password = txtPassword.Text.Trim();
                modificarUsuario.Nombres = txtNombres.Text.Trim();
                modificarUsuario.Apellidos= txtApellidos.Text.Trim();
                modificarUsuario.Correo = txtCorreo.Text.Trim();
                modificarUsuario.AreaID = ((Area)btnArea.Tag).AreaID;
                repositorio.Actualizar(modificarUsuario);
                repositorio.Guardar();
                MessageBox.Show("Se modifico correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (btnArea.Tag == null) throw new ArgumentException("Tiene que seleccionar un area");
                if (string.IsNullOrEmpty(txtPassword.Text)) throw new ArgumentException("No puede dejar la contraseña en blanco");
                var nuevoUsuario = new Usuario();
                nuevoUsuario.NombreUsuario = txtUsuario.Text.Trim();
                nuevoUsuario.Password = txtPassword.Text.Trim();
                nuevoUsuario.Nombres = txtNombres.Text.Trim();
                nuevoUsuario.Apellidos = txtApellidos.Text;
                nuevoUsuario.Correo = txtCorreo.Text;
                nuevoUsuario.AreaID = ((Area)btnArea.Tag).AreaID;
                var buscarUsuario = repositorio.Obtener(usuario => usuario.Nombres.ToUpper() == usuario.NombreUsuario.ToUpper());
                if (buscarUsuario.Any()) throw new ArgumentException($"Ya existe un usuario registrado como {txtUsuario.Text}");                
                repositorio.Agregar(nuevoUsuario);
                repositorio.Guardar();
                MessageBox.Show("Se creo correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar()
        {
            var Id = int.Parse(txtUsuario.Tag.ToString());
            var eliminar = repositorio.ObtenerUno(Id);
            if (eliminar == null) throw new ArgumentException("No se encontro el usuario");
            repositorio.Eliminar(eliminar);
            repositorio.Guardar();
            MessageBox.Show("Se elimino correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvArea_Click(object sender, EventArgs e)
        {
            try
            {
                txtUsuario.Text = gvUsuarios.GetFocusedRowCellValue("Usuario").ToString();                
                txtNombres.Text = gvUsuarios.GetFocusedRowCellValue("Nombres").ToString();                
                txtApellidos.Text = gvUsuarios.GetFocusedRowCellValue("Apellidos").ToString();
                txtCorreo.Text = gvUsuarios.GetFocusedRowCellValue("Correo").ToString();
                btnArea.Tag = (Area)gvUsuarios.GetFocusedRowCellValue("area");
                btnArea.Text = ((Area)gvUsuarios.GetFocusedRowCellValue("area")).Nombre;
                txtUsuario.Focus();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                modificar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnCategoria_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                BuscarArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCategoria_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCategoria_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarArea()
        {
            var buscar = new FrmBuscar<Area>("Buscar area", "AreaID", "Nombre");
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                var area = buscar.resultado;
                btnArea.Text = area.Nombre;
                btnArea.Tag = area;
            }
        }

        
    }
}