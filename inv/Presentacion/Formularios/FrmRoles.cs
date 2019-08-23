using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorios;
using Repositorios.Dto;

namespace Presentacion.Formularios
{
    public partial class FrmRoles : DevExpress.XtraEditors.XtraForm
    {
        private readonly RolRepositorio repositorio;
        List<RolAccesoDto> roles;

        public FrmRoles()
        {
            InitializeComponent();
            repositorio = new RolRepositorio();
            roles = repositorio.ObtenerRoles();
            gRoles.DataSource = roles;
        }

        private void FrmRoles_Load(object sender, EventArgs e)
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
            roles = repositorio.ObtenerRoles();
            gRoles.DataSource = roles;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                RolAcceso.FrmNuevoRol frmNuevo = new RolAcceso.FrmNuevoRol();
                frmNuevo.repositorio = repositorio;
                if (frmNuevo.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                repositorio.repositorioRolAcceso.ActualizarMultiRolAcceso(roles);
                MessageBox.Show("Se actualizo correctamente", "Roles", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
