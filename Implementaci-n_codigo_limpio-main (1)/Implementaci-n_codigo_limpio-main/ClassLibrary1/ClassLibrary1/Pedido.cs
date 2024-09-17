using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pedido: Restaurante
    {
        public int Id { get; set; } = 1;

        public List<string> Productos_pedido { get; set; }

        public int Numero_mesa { get; set; }

   
        public Pedido(List<string> productos, int numero_mesa) {
            Id++;
            Productos_pedido = productos;
            Numero_mesa = numero_mesa;

        }
        public void Crear_pedido(string nombre_mesero, List<string> productos, int numero_mesa)
        {
           foreach (Mesero mesero in Meseros)
            {
                if (mesero.Nombre == nombre_mesero)
                {
                    Pedido pedido = mesero.Crear_pedido(productos, numero_mesa);
                    foreach(Mesa mesa in Mesas)
                    {
                        if (mesa.numero_mesa == numero_mesa)
                        {
                            mesa.disponibilidad = false;
                        }
                    }
                    Pedidos.Add(pedido);
                }
        }
        public float Liquidar_pedido(int id_pedido)
        {
            float valor_total = 0;
            foreach (Pedido pedido in Pedidos)
            {
                if( pedido.Id == id_pedido)
                {
                    foreach (string producto in pedido.Productos_pedido)
                    {
                        foreach (Producto producto_menu in Menu_restaurante.Productos)
                        {
                            if (producto_menu.Nombre == producto)
                            {
                                valor_total += producto_menu.Precio;
                            }
                        }
                    }
                    foreach (Mesa mesa in Mesas)
                    {
                        if(mesa.numero_mesa == pedido.Numero_mesa)
                        {
                            mesa.disponibilidad = true;
                        }
                    }
                }

            }
            foreach(Mesero mesero in Meseros)
            {
                foreach(int pedido in mesero.Pedidos_tomados)
                {
                    if(pedido == id_pedido)
                    {
                        mesero.Propinas = mesero.Propinas + (valor_total / 10);
                    }
                }
            }
            return valor_total;
        }
    }
}