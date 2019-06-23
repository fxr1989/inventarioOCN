using DevExpress.XtraEditors;
using Presentacion.Helper;


namespace Presentacion.Extensiones
{
    public static class ExtencionBotonesAccion
    {
        public static EnumBotonAccion Accion(this SimpleButton boton)
        {
            int idAccion;
            int.TryParse(boton.Tag.ToString(), out idAccion);            
            switch (idAccion)
            {
                case 1:
                    return EnumBotonAccion.Nuevo;
                case 2:
                    return EnumBotonAccion.Modificar;
                case 3:
                    return EnumBotonAccion.Eliminar;
                case 4:
                    return EnumBotonAccion.Guardar;
                case 5:
                    return EnumBotonAccion.Cancelar;
                default:
                    return EnumBotonAccion.Nuevo;                    
            }
        }
    }
}
