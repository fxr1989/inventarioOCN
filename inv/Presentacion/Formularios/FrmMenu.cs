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
    }
}