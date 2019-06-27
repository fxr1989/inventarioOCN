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

namespace Presentacion.Formularios
{
    public partial class FrmEntrada : DevExpress.XtraEditors.XtraForm
    {
        ObservableCollection<EntradaLineaDto> lineas;
        private EntradaRepositorio repositorio;
        public FrmEntrada()
        {
            InitializeComponent();
            lineas = new ObservableCollection<EntradaLineaDto>();
            gLinea.DataSource = lineas;
            repositorio = new EntradaRepositorio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lineas.Add(new EntradaLineaDto());
        }

        private void FrmEntrada_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombobox();
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
                if (e.Column.FieldName == "Cantidad" || e.Column.FieldName == "PrecioUnitario" || e.Column.FieldName == "Donacion")
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
            decimal total = 0;
            decimal totalDonacion = 0;
            foreach (var item in lineas)
            {
                if (item.Donacion)
                    totalDonacion = totalDonacion + item.Total;
                else
                    total = total + item.Total;
            }
            txtTotal.Text = total.ToString("0.00");
            txtTotalDonacion.Text = totalDonacion.ToString("0.00");
        }

        private void btnGuardarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (!lineas.Any()) throw new ArgumentException("Tiene que ingresar productos");
                Entrada entrada = new Entrada();
                entrada.lineas = new List<EntradaLinea>();
                foreach (var linea in lineas)
                {
                    entrada.lineas.Add(new EntradaLinea()
                    {
                        productoID = linea.productoID,
                        ubicacionID = linea.ubicacionID,
                        Cantidad = linea.Cantidad,
                        PrecioUnitario = linea.PrecioUnitario,
                        Total = linea.Total,
                        Donacion = linea.Donacion,
                        FechaIngreso = DateTime.Now,
                        Observacion = linea.Observacion
                    });
                }
                entrada.Fecha = Convert.ToDateTime(deFechaEntrada.EditValue);
                entrada.FechaIngreso = DateTime.Now;
                entrada.Total = Convert.ToDecimal(txtTotal.Text);
                entrada.TotalDonaciones = Convert.ToDecimal(txtTotalDonacion.Text);
                entrada.usuarioID = 1;
                repositorio.Agregar(entrada);
                MessageBox.Show("Se agrego entrada correctamente.", "Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}