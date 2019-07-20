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

namespace Presentacion.Formularios
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public int CantidadIntentos { get; set; }
        private readonly UsuarioRepositorio repositorio;
        public FrmLogin()
        {
            repositorio = new UsuarioRepositorio();
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CantidadIntentos = 0;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                var nombreUsuario = txtUsuario.Text;
                var password = txtPassword.Text;
                var usuario = repositorio.Login(nombreUsuario, password);
                if (usuario == null)
                {
                    CantidadIntentos++;
                    MessageBox.Show("Usuario o Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Informacion.Sesion.Usuario = usuario;
                    CantidadIntentos = 0;
                    DialogResult = DialogResult.OK;
                }
                if (CantidadIntentos == 3)
                    DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    btnAcceder_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}