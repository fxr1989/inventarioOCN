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
using Modelo;
using Repositorios;

namespace Presentacion.Formularios.RolAcceso
{
    public partial class FrmNuevoRol : DevExpress.XtraEditors.XtraForm
    {
        public RolRepositorio repositorio;

        public FrmNuevoRol()
        {
            InitializeComponent();
        }

        private void FrmNuevoRol_Load(object sender, EventArgs e)
        {

        }

        private void FrmNuevoRol_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Guardar();
                    DialogResult = DialogResult.OK;
                }
                if (e.KeyCode == Keys.Escape)
                    this.DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void Guardar()
        {
            Rol nuevoRol = new Rol();
            nuevoRol.Nombre = txtNombreRol.Text;
            repositorio.AgregarRol(nuevoRol);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
    }
}