using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto: class Restaurante
    {
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public List<string> Material_necesario {get; set;}

        public Producto(string nombre , float precio, List<string> material)
        {
            Nombre = nombre;
            Precio = precio;
            Material_necesario = material;
        }
        public void Agregar_producto_pedido(int id_pedido, string nombre_producto)
        {
            foreach (Pedido pedido in Pedidos)
            {
                if (pedido.Id == id_pedido)
                {
                    pedido.Productos_pedido.Add(nombre_producto);
                }

            }
        }
        public void Eliminar_producto_pedido(int id_pedido, string nombre_producto)
        {
            foreach (Pedido pedido in Pedidos)
            {
                if (pedido.Id == id_pedido)
                {
                    foreach (string producto in pedido.Productos_pedido)
                    {
                        if(producto == nombre_producto)
                        {
                            pedido.Productos_pedido.Remove(nombre_producto);
                        }
                    }
                }

            }
        }
    }
}
