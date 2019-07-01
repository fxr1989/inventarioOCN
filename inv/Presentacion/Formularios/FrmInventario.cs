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
using Modelo;

namespace Presentacion.Formularios
{
    public partial class FrmInventario : DevExpress.XtraEditors.XtraForm
    {
        private readonly InventarioRepositorio repositorio;
        public bool vistaModalBusqueda;
        public Inventario inventario;

        public FrmInventario()
        {
            InitializeComponent();
            repositorio = new InventarioRepositorio();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
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
            var movimientos = (from movimiento in repositorio.Obtener()
                               select new
                               {
                                   movimiento.InventarioID,
                                   movimiento.productoID,
                                   movimiento.ubicacionID,
                                   Producto = movimiento.producto.Nombre,
                                   Ubicacion = movimiento.ubicacion.Nombre,
                                   movimiento.Cantidad
                               }).ToList();
            gInventario.DataSource = movimientos;
            gvInventario.Columns["productoID"].Visible = false;
            gvInventario.Columns["ubicacionID"].Visible = false;
            gvInventario.Columns["InventarioID"].Visible = false;
        }

        private void gvInventario_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (vistaModalBusqueda)
                {
                    if (gvInventario.GetFocusedRow() != null)
                    {
                        Inventario productoInventario = new Inventario();
                        productoInventario.Cantidad = Convert.ToInt32(gvInventario.GetFocusedRowCellValue("Cantidad"));
                        productoInventario.productoID = Convert.ToInt32(gvInventario.GetFocusedRowCellValue("productoID"));
                        productoInventario.ubicacionID = Convert.ToInt32(gvInventario.GetFocusedRowCellValue("ubicacionID"));
                        productoInventario.producto = new Producto() { Nombre = gvInventario.GetFocusedRowCellValue("Producto").ToString() };
                        productoInventario.ubicacion = new Ubicacion() { Nombre = gvInventario.GetFocusedRowCellValue("Ubicacion").ToString() };
                        inventario = productoInventario;
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}