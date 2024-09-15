using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto
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
            
        }
        public void Eliminar_producto_pedido(int id_pedido, string nombre_producto)
        {
            
        }
    }
}
