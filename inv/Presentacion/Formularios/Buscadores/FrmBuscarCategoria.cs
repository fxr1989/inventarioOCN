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
using Repositorios;
using Repositorios.Interface;
using Modelo;
using DevExpress.XtraGrid.Columns;

namespace Presentacion.Formularios.Buscadores
{
    public partial class FrmBuscarCategoria<T> : DevExpress.XtraEditors.XtraForm where T: class
    {
        private IRepositorio<T> repositorio;
        private string nombreColumnaMostrar1;
        private string nombreColumnaMostrar2;
        public T resultado;
        public FrmBuscarCategoria()
        {
            repositorio = new Repositorio<T>();
            InitializeComponent();
        }

        public FrmBuscarCategoria(string tituloFormulario, string columnaMostrar1, string columnaMostrar2)
        {
            Text = tituloFormulario;
            nombreColumnaMostrar1 = columnaMostrar1;
            nombreColumnaMostrar2 = columnaMostrar2;
            repositorio = new Repositorio<T>();
            InitializeComponent();
        }

        private void FrmBuscarCategoria_Load(object sender, EventArgs e)
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

        private void CargarDatos()
        {
            var datos = repositorio.Obtener().ToList();
            gBuscar.DataSource = datos;
            foreach (GridColumn columna in gvBuscar.Columns)
            {
                columna.Visible = columna.FieldName == nombreColumnaMostrar1 || columna.FieldName == nombreColumnaMostrar2;
            }            
        }

        private void gvBuscar_DoubleClick(object sender, EventArgs e)
        {
            resultado = (T)gvBuscar.GetFocusedRow();
            DialogResult = DialogResult.OK;
        }
    }
}