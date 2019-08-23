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
using Presentacion.Helper;
using Presentacion.Extensiones;
using Repositorios;
using Repositorios.Interface;
using Modelo;
using Presentacion.Formularios.Buscadores;

namespace Presentacion.Formularios
{
    public partial class FrmProducto : DevExpress.XtraEditors.XtraForm
    {
        private HelperFormulario helper;
        private IRepositorio<Producto> productoRepositorio;
        private bool modificar;
        public Modelo.RolAcceso acceso;

        public FrmProducto()
        {
            InitializeComponent();
            helper = new HelperFormulario();
            productoRepositorio = new Repositorio<Producto>();
        }

        private void FrmArea_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BotonAccionClick(object sender, EventArgs e)
        {
            try
            {
                var accion = ((SimpleButton)sender).Accion();
                var ejecutarAccion = ValidarAccion(accion);
                if (ejecutarAccion)
                    helper.BotonesAccion(btnNuevo, btnModificar, btnEliminar, btnGuardar, btnCancelar, accion, gcDatosAreas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private bool ValidarAccion(EnumBotonAccion accion)
        {            
            if (accion == EnumBotonAccion.Nuevo)
                return true;
            if (accion == EnumBotonAccion.Modificar)
                return true;
            if (accion == EnumBotonAccion.Cancelar)
                return true;
            if (accion == EnumBotonAccion.Guardar)
            {
                if (MessageBox.Show($"Seguro que desea guardar el producto {txtNombre.Text.Trim()}", "Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Guardar();
                    CargarDatos();
                    return true;
                }
                return false;
            }            
            if (accion == EnumBotonAccion.Eliminar)
            {
                if (MessageBox.Show($"Seguro que desea eliminar el producto {txtNombre.Text.Trim()}", "Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Eliminar();
                    CargarDatos();
                    return true;
                }
                return false;
            }
            return false;
        }

        private void CargarDatos()
        {
            var productos = (
                                from producto in productoRepositorio.Obtener()
                                select new {
                                            producto.ProductoID,
                                            producto.Codigo,
                                            producto.Nombre,
                                            Categoria = producto.categoria.Nombre,
                                            Marca = producto.marca.Nombre,
                                            producto.Modelo,
                                            producto.NumeroSerie,
                                            producto.Descripcion,
                                            producto.CodigoBarra,
                                            producto.categoria,
                                            producto.marca
                                          }
                            ).ToList();
            gProducto.DataSource = productos;
            gvProducto.Columns["categoria"].Visible = false;
            gvProducto.Columns["marca"].Visible = false;
        }

        private void Guardar()
        {
            if (modificar)
            {
                var productoId = int.Parse(txtCodigo.Tag.ToString());
                var modificarProducto = productoRepositorio.ObtenerUno(productoId);
                var buscarCodigo = productoRepositorio.Obtener(
                                                                    categoria =>    categoria.Codigo.ToUpper() != modificarProducto.Codigo.ToUpper() && 
                                                                                    categoria.Codigo.ToUpper() == txtCodigo.Text.ToUpper());
                if (buscarCodigo.Count() > 0) throw new ArgumentException($"Ya existe producto con el codigo {txtCodigo.Text}");
                var buscarNombre = productoRepositorio.Obtener(
                                                                    categoria => categoria.Nombre.ToUpper() != modificarProducto.Nombre.ToUpper() &&
                                                                                    categoria.Nombre.ToUpper() == txtCodigo.Text.ToUpper());
                if (buscarCodigo.Count() > 0) throw new ArgumentException($"Ya existe producto con el nombre {txtNombre.Text}");
                modificarProducto.Codigo = txtCodigo.Text.Trim();
                modificarProducto.Nombre = txtNombre.Text.Trim();
                modificarProducto.Modelo = txtModelo.Text.Trim();
                modificarProducto.Descripcion = txtDescripcion.Text.Trim();
                modificarProducto.CodigoBarra = txtCodigoBarra.Text.Trim();
                modificarProducto.NumeroSerie = txtNumeroSerial.Text.Trim();
                modificarProducto.categoriaID = ((Categoria)btnCategoria.Tag).CategoriaID;
                modificarProducto.marcaID = ((Marca)btnMarca.Tag).MarcaID;
                productoRepositorio.Actualizar(modificarProducto);
                productoRepositorio.Guardar();
                MessageBox.Show("Se modifico correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (btnCategoria.Tag == null) throw new ArgumentException("Tiene que seleccionar una categoria");
                var nuevoProducto = new Producto();
                nuevoProducto.Codigo = txtCodigo.Text.Trim();
                nuevoProducto.Nombre = txtNombre.Text.Trim();
                nuevoProducto.Modelo = txtModelo.Text.Trim();
                nuevoProducto.NumeroSerie = txtNumeroSerial.Text.Trim();
                nuevoProducto.Descripcion = txtDescripcion.Text.Trim();
                nuevoProducto.CodigoBarra = txtCodigoBarra.Text.Trim();
                nuevoProducto.categoriaID = ((Categoria)btnCategoria.Tag).CategoriaID;
                nuevoProducto.marcaID = ((Marca)btnMarca.Tag).MarcaID;
                var buscarCodigo = productoRepositorio.Obtener(producto => producto.Codigo.ToUpper() == nuevoProducto.Codigo.ToUpper());
                if (buscarCodigo.Any()) throw new ArgumentException($"Ya existe producto con el codigo {txtCodigo.Text}");
                var buscarNombre = productoRepositorio.Obtener(producto => producto.Nombre.ToUpper() == nuevoProducto.Nombre.ToUpper());
                if (buscarNombre.Any()) throw new ArgumentException($"Ya existe producto con el nombre {txtNombre.Text}");
                productoRepositorio.Agregar(nuevoProducto);
                productoRepositorio.Guardar();
                MessageBox.Show("Se creo correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminar()
        {
            var Id = int.Parse(txtCodigo.Tag.ToString());
            var eliminar = productoRepositorio.ObtenerUno(Id);
            if (eliminar == null) throw new ArgumentException("No se encontro el producto");
            productoRepositorio.Eliminar(eliminar);
            productoRepositorio.Guardar();
            MessageBox.Show("Se elimino correctamente", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvArea_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Tag = gvProducto.GetFocusedRowCellValue("ProductoID").ToString();
                txtCodigo.Text = gvProducto.GetFocusedRowCellValue("Codigo").ToString();
                txtNombre.Text = gvProducto.GetFocusedRowCellValue("Nombre").ToString();
                txtModelo.Text = gvProducto.GetFocusedRowCellValue("Modelo").ToString();
                txtNumeroSerial.Text = gvProducto.GetFocusedRowCellValue("NumeroSerie").ToString();
                txtDescripcion.Text = gvProducto.GetFocusedRowCellValue("Descripcion").ToString();
                txtCodigoBarra.Text = gvProducto.GetFocusedRowCellValue("CodigoBarra").ToString();
                btnCategoria.Tag = (Categoria)gvProducto.GetFocusedRowCellValue("categoria");
                btnCategoria.Text = ((Categoria)gvProducto.GetFocusedRowCellValue("categoria")).Nombre;
                btnMarca.Tag = (Marca)gvProducto.GetFocusedRowCellValue("marca");
                btnMarca.Text = ((Marca)gvProducto.GetFocusedRowCellValue("marca")).Nombre;
                txtCodigo.Focus();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                modificar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnCategoria_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                BuscarCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCategoria_DoubleClick(object sender, EventArgs e)
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
        private void btnCategoria_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void BuscarCategoria()
        {
            var buscar = new FrmBuscar<Categoria>("Buscar categoria", "CategoriaID", "Nombre");
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                var categoria = buscar.resultado;
                btnCategoria.Text = categoria.Nombre;
                btnCategoria.Tag = categoria;
            }
        }

        private void BuscarMarca()
        {
            var buscar = new FrmBuscar<Marca>("Buscar marca", "MarcaID", "Nombre");
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                var marca = buscar.resultado;
                btnMarca.Text = marca.Nombre;
                btnMarca.Tag = marca;
            }
        }

        private void btnMarca_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                BuscarMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarca_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                BuscarMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}