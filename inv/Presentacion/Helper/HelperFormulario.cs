using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraLayout;

namespace Presentacion.Helper
{
    public class HelperFormulario
    {
        public void BotonesAccion(SimpleButton btnNuevo, SimpleButton btnModificar, SimpleButton btnEliminar, SimpleButton btnGuardar, SimpleButton btnCancelar, EnumBotonAccion accion, GroupControl grupoControles)
        {
            switch (accion)
            {
                case EnumBotonAccion.Nuevo:
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    LimpiarControles(grupoControles);
                    HabilitarPropiedadReadOnly(grupoControles, false);
                    break;
                case EnumBotonAccion.Modificar:
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    HabilitarPropiedadReadOnly(grupoControles, false);
                    break;
                case EnumBotonAccion.Eliminar:
                case EnumBotonAccion.Guardar:
                case EnumBotonAccion.Cancelar:
                default:
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    LimpiarControles(grupoControles);
                    HabilitarPropiedadReadOnly(grupoControles, true);
                    break;
            }
        }

        public void HabilitarPropiedadReadOnly(GroupControl grupo, bool readOnly)
        {
            foreach (Control control in grupo.Controls)
            {
                if (control is LayoutControl)
                {
                    foreach (Control controlLayout in control.Controls)
                    {
                        if (controlLayout is TextEdit)
                            ((TextEdit)controlLayout).Properties.ReadOnly = readOnly;                        
                    }
                }                
            }
        }

        public void LimpiarControles(GroupControl grupo)
        {
            foreach (Control control in grupo.Controls)
            {
                if (control is LayoutControl)
                {
                    foreach (Control controlLayout in control.Controls)
                    {
                        if (controlLayout is TextEdit)
                            ((TextEdit)controlLayout).Text = string.Empty;
                    }
                }
            }
        }
    }
}
