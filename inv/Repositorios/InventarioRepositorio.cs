using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Repositorios.Interface;
using DataBaseContext;
using Repositorios.Dto;

namespace Repositorios
{
    public class InventarioRepositorio : Repositorio<Inventario> 
    {
        public InventarioRepositorio(): base()
        {

        }

        public InventarioRepositorio(InvContext context): base(context)
        {

        }

        public void EntradaMovimiento(Entrada entrada)
        {
            var listaProducto = entrada
                                .lineas
                                .Select(linea => new { linea.productoID, linea.ubicacionID })
                                .Distinct();
            foreach (var lineaProducto in listaProducto)
            {
                var lineas = entrada
                                .lineas
                                .Where(linea => linea.productoID == lineaProducto.productoID && linea.ubicacionID == lineaProducto.ubicacionID);
                var invetario = db.Inventarios.Find(lineaProducto.productoID, lineaProducto.ubicacionID);
                if (invetario == null)
                {
                    var nuevoInventario = new Inventario();
                    nuevoInventario.productoID = lineaProducto.productoID;
                    nuevoInventario.ubicacionID = lineaProducto.ubicacionID;
                    nuevoInventario.Cantidad = lineas.Sum(linea => linea.Cantidad);
                    Agregar(nuevoInventario);
                }
                else
                {
                    invetario.Cantidad += lineas.Sum(linea => linea.Cantidad);
                    Actualizar(invetario);
                }
            }
        }

        public void SalidaMovimiento(Salida salida)
        {
            var listaProducto = salida
                                .lineas
                                .Select(linea => new { linea.productoID, linea.ubicacionID })
                                .Distinct();
            foreach (var lineaProducto in listaProducto)
            {
                var lineas = salida
                                .lineas
                                .Where(linea => linea.productoID == lineaProducto.productoID && linea.ubicacionID == lineaProducto.ubicacionID);
                var invetario = db.Inventarios.Find(lineaProducto.productoID, lineaProducto.ubicacionID);
                if (invetario == null)
                {
                    var nuevoInventario = new Inventario();
                    nuevoInventario.productoID = lineaProducto.productoID;
                    nuevoInventario.ubicacionID = lineaProducto.ubicacionID;
                    nuevoInventario.Cantidad = lineas.Sum(linea => linea.Cantidad) * -1;
                    Agregar(nuevoInventario);
                }
                else
                {
                    invetario.Cantidad -= lineas.Sum(linea => linea.Cantidad);
                    Actualizar(invetario);
                }
            }
        }

    }
}
