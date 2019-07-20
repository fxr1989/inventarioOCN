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

        private void btnCategorias_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void btnUbicacion_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUbicacion frmUbicacion = new FrmUbicacion();
            frmUbicacion.MdiParent = this;
            frmUbicacion.Show();

        }

        private void btnProductos_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.MdiParent = this;
            frmProducto.Show();
        }

        private void btnArea_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmArea frmArea = new FrmArea();
            frmArea.MdiParent = this;
            frmArea.Show();
        }

        private void btnUusarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void btnEntrada_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmEntrada frmEntrada = new FrmEntrada();
            frmEntrada.MdiParent = this;
            frmEntrada.Show();
        }

        private void btnSalida_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSalida frmSalida = new FrmSalida();
            frmSalida.MdiParent = this;
            frmSalida.Show();
        }

        private void btnInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.MdiParent = this;
            frmInventario.Show();
        }       

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            bstUsuario.Caption = $"{Sesion.Usuario.NombreUsuario} {Sesion.Usuario.Apellidos}";            
        }
    }
}