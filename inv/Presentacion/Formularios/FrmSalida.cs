using System;
using System.Linq;
using System.Windows.Forms;
using Modelo;
using System.Collections.ObjectModel;
using Repositorios;
using Presentacion.Formularios.Buscadores;
using DevExpress.XtraEditors;
using Repositorios.Dto;
using AutoMapper;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace Presentacion.Formularios
{
    public partial class FrmSalida : DevExpress.XtraEditors.XtraForm
    {
        ObservableCollection<SalidaLineaDto> lineas;
        private SalidaRepositorio repositorio;
        public FrmSalida()
        {
            InitializeComponent();
            lineas = new ObservableCollection<SalidaLineaDto>();
            gLinea.DataSource = lineas;
            repositorio = new SalidaRepositorio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmInventario buscarMovimiento = new FrmInventario();
            buscarMovimiento.vistaModalBusqueda = true;
            if (buscarMovimiento.ShowDialog() == DialogResult.OK)
            {
                var nuevaLinea = new SalidaLineaDto();
                nuevaLinea.NombreUbicacion = buscarMovimiento.inventario.ubicacion.Nombre;
                nuevaLinea.NombreProducto = buscarMovimiento.inventario.producto.Nombre;
                nuevaLinea.productoID = buscarMovimiento.inventario.productoID;
                nuevaLinea.ubicacionID = buscarMovimiento.inventario.ubicacionID;
                nuevaLinea.Disponible = buscarMovimiento.inventario.Cantidad;                
                lineas.Add(nuevaLinea);
            }
        }

        private void FrmEntrada_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombobox();
                txtUsuario.Text = $"{Informacion.Sesion.Usuario.Nombres} {Informacion.Sesion.Usuario.Apellidos}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CargarCombobox()
        {
            //ubicacion
            var ubicacion = repositorio.ubicacion.Obtener().ToList();
            repCboUbicacion.DisplayMember = "Nombre";
            repCboUbicacion.ValueMember = "UbicacionID";
            repCboUbicacion.DataSource = ubicacion;
            //productos
            var productos = (from producto in repositorio.producto.Obtener()
                            select new
                            {
                                producto.ProductoID,
                                producto.Codigo,
                                producto.Nombre,                                
                                Categoria = producto.categoria.Nombre
                            }).ToList();
            repCboProductos.DisplayMember = "Nombre";
            repCboProductos.ValueMember = "ProductoID";
            repCboProductos.DataSource = productos;
            repCboProductos.PopulateColumns();
            repCboProductos.Columns["ProductoID"].Visible = false;
        }
        private void gvLinea_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Cantidad")
                {
                    ActualizarTotales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void ActualizarTotales()
        {
            decimal cantidaTotal = 0;            
            foreach (var item in lineas)
            {
                cantidaTotal += item.Cantidad;
            }
            txtTotal.Text = cantidaTotal.ToString();            
        }

        private void btnGuardarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (!lineas.Any()) throw new ArgumentException("Tiene que ingresar productos");
                Salida salida = new Salida();
                salida.lineas = new List<SalidaLinea>();
                foreach (var linea in lineas)
                {
                    salida.lineas.Add(new SalidaLinea()
                    {
                        productoID = linea.productoID,
                        ubicacionID = linea.ubicacionID,
                        Cantidad = linea.Cantidad,                        
                        FechaIngreso = DateTime.Now,
                        Observacion = linea.Observacion
                    });
                }
                salida.Fecha = Convert.ToDateTime(deFechaEntrada.EditValue ?? DateTime.Now);
                salida.FechaIngreso = DateTime.Now;
                salida.CantidadTotal = Convert.ToInt32(txtTotal.Text);
                salida.usuarioID = Informacion.Sesion.Usuario.UsuarioID;
                repositorio.Agregar(salida);
                if (MessageBox.Show("Se realizo la salida correctamente.Desea imprimir el acta?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    VistaPrevia(salida);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VistaPrevia(Salida salida)
        {
            Reportes.rptSalida reporte = new Reportes.rptSalida();            
            reporte.Parameters["pNombreUsuario"].Value = txtUsuario.Text;
            reporte.Parameters["pFecha"].Value = salida.FechaIngreso;
            reporte.DataSource = lineas;
            reporte.ShowRibbonPreview();
        }
    }
}