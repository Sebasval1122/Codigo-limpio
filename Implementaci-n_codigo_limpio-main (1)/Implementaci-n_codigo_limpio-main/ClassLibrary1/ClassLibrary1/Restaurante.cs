using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Restaurante
    {
        List<Mesero> Meseros { get; set; }
        Menu Menu_restaurante { get; set; }
        Inventario Inventario { get; set; }
        List<Pedido> Pedidos { get; set; }
        List<Mesa> Mesas { get; set; }

        void Crear_pedido(string nombre_mesero, List<string> productos, int numero_mesa);
        float Liquidar_pedido(int id_pedido);
        string Buscar_mesero(string nombre_mesero);
        string Visualizar_mesas();
        void Agregar_mesa(int capacidad);
        void Agregar_producto_pedido(int id_pedido, string nombre_producto);
        void Eliminar_producto_pedido(int id_pedido, string nombre_producto);
    }
}
