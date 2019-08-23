using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Presentacion.Formularios;
using DevExpress.XtraReports.UI;
using Presentacion.Informacion;

namespace Presentacion
{
    public partial class FrmMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private bool Abrir(Form formulario, out Modelo.RolAcceso acceso)
        {            
            acceso = null;
            try
            {
                bool abrir = false;
                foreach (var rolAcceso in Sesion.Usuario.rol.accesos)
                {
                    if (rolAcceso.permiso.Formulario == formulario.Name)
                    {
                        if (rolAcceso.Agregar || rolAcceso.Editar || rolAcceso.Eliminar || rolAcceso.Ver)
                        {
                            acceso = rolAcceso;
                            abrir = true;
                            break;
                        }
                        continue;
                    }
                }                
                return abrir;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnCategorias_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmCategoria, out acceso)) return;
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void btnUbicacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUbicacion frmUbicacion = new FrmUbicacion();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmUbicacion, out acceso)) return;
            frmUbicacion.MdiParent = this;
            frmUbicacion.Show();

        }

        private void btnProductos_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmProducto, out acceso)) return;
            frmProducto.MdiParent = this;
            frmProducto.Show();
        }

        private void btnArea_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmArea frmArea = new FrmArea();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmArea, out acceso)) return;
            //frmArea.acceso = acceso;
            frmArea.MdiParent = this;
            frmArea.Show();
        }

        private void btnUusarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmUsuario, out acceso)) return;
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void btnEntrada_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEntrada frmEntrada = new FrmEntrada();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmEntrada, out acceso)) return;
            frmEntrada.MdiParent = this;
            frmEntrada.Show();
        }

        private void btnSalida_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSalida frmSalida = new FrmSalida();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmSalida, out acceso)) return;
            frmSalida.MdiParent = this;
            frmSalida.Show();
        }

        private void btnInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmInventario, out acceso)) return;
            frmInventario.MdiParent = this;
            frmInventario.Show();
        }       

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            bstUsuario.Caption = $"{Sesion.Usuario.NombreUsuario} {Sesion.Usuario.Apellidos}";            
        }

        private void btnRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmRoles frmRoles = new FrmRoles();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmRoles, out acceso)) return;
            frmRoles.MdiParent = this;
            frmRoles.Show();
        }

        private void btnMarca_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            Modelo.RolAcceso acceso;
            //if (!Abrir(frmMarca, out acceso)) return;
            frmMarca.MdiParent = this;
            frmMarca.Show();
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.MdiParent = this;
            frmAbout.Show();
        }
    }
}