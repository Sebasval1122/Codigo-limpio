namespace ClassLibrary1{
    public class Gestion: Gestor
    {
        public void Gestion_Administrador()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Buscar mesero");
            Console.WriteLine("2. Visualizar mesas");
            Console.WriteLine("3. Agregar mesa nueva");
            Console.WriteLine("4. Agregar producto a menu");
            Console.WriteLine("5. Eliminar producto de menu");
            Console.WriteLine("6. Agregar nuevo material a inventario");
            Console.WriteLine("7. Eliminar material a inventario");
            Console.WriteLine("8. Agregar cantidad a un material de inventario");
            Console.WriteLine("9. Eliminar una cantidad de material de inventario");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("Escriba el nombre del mesero que quiere encontrar");
                string nombre_mesero = Console.ReadLine();
                string encontrado = Restaurante.Buscar_mesero(nombre_mesero);
                Console.WriteLine($"Mesero encontrado: {encontrado}");
                Guardar_Archivo();
            }
            else if (opcion == "2")
            {
                string mesas = restaurante.Visualizar_mesas();
                Console.WriteLine($"Mesas del restaurante: {mesas}");

            }
            else if (opcion == "3")
            {
                Console.WriteLine("Introduzca la mesa capacidad de su nueva mesa");
                string capacidad = Console.ReadLine();
                int numero_mesa = Int32.Parse(capacidad);
                restaurante.Agregar_mesa(numero_mesa);
                Console.WriteLine("Mesa agregada con exito");
                Guardar_Archivo();
            }
            else if (opcion == "4")
            {
                Console.WriteLine("Introduzca el nombre de su nuevo producto");
                string nombre_producto = Console.ReadLine();
                Console.WriteLine("Introduzca el valor de su nuevo producto");
                string valor = Console.ReadLine();
                float valor_producto = Convert.ToSingle(valor);
                Console.WriteLine("Introduzca la lista de materiales de su nuevo producto");
                string materiales = Console.ReadLine();
                char[] comas = { ',', ';' };
                string[] substrings = materiales.Split(comas, StringSplitOptions.RemoveEmptyEntries);
                List<string> lista_materiales = new List<string>(substrings);
                restaurante.Menu_restaurante.Agregar_producto(nombre_producto, valor_producto, lista_materiales);
                Console.WriteLine("Nuevo producto agregado con exito");
                Guardar_Archivo();
            }
            else if (opcion == "5")
            {
                Console.WriteLine("Introduzca el nombre del producto a eliminar");
                string nombre_producto = Console.ReadLine();
                restaurante.Menu_restaurante.Eliminar_producto(nombre_producto);
                Console.WriteLine("Producto eliminado con exito");
                Guardar_Archivo();
            }
            else if(opcion == "6")
            {
                Console.WriteLine("Introduzca el nombre del nuevo material a ingresar:");
                string nombre_material = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad que desea agregar");
                string cantidad = Console.ReadLine();
                int numero_cantidad = Int32.Parse(cantidad);
                restaurante.Inventario.Agregar_material(nombre_material, numero_cantidad);
                Console.WriteLine("Material agregado con exito");
                Guardar_Archivo();
            }
            else if(opcion == "7")
            {
                Console.WriteLine("Introduzca el nombre del material a eliminar");
                string nombre_material = Console.ReadLine();
                restaurante.Inventario.Eliminar_material(nombre_material);
                Console.WriteLine("Material eliminado con exito");
                Guardar_Archivo();
            }
            else if(opcion == "8")
            {
                Console.WriteLine("Introduzca el nombre del material al cual quiere agregar mas unidades:");
                string nombre_material = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad que desea agregar");
                string cantidad = Console.ReadLine();
                int numero_cantidad = Int32.Parse(cantidad);
                restaurante.Inventario.Agregar_cantidad_material(nombre_material, numero_cantidad);
                Console.WriteLine("Cantidad agregada al material con exito");
                Guardar_Archivo();
            }
            else if (opcion == "9")
            {
                Console.WriteLine("Introduzca el nombre del material al cual quiere eliminar unidades:");
                string nombre_material = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad que desea eliminar");
                string cantidad = Console.ReadLine();
                int numero_cantidad = Int32.Parse(cantidad);
                restaurante.Inventario.Eliminar_cantidad_material(nombre_material, numero_cantidad);
                Console.WriteLine("Cantidad eliminada con exito");
                Guardar_Archivo();
            }
            else
            {
                Console.WriteLine("Introduzca una opcion valida");
                Gestion_Administrador();
            }
     
        }

        public void Gestion_Mesero(string nombre_mesero)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Crear pedido");
            Console.WriteLine("2. Liquidar pedido");
            Console.WriteLine("3. Agregar producto a pedido");
            Console.WriteLine("4. Eliminar producto a pedido");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("Introduzca la mesa de su pedido");
                string mesa_pedido = Console.ReadLine();
                int numero_mesa = Int32.Parse(mesa_pedido);
                Console.WriteLine("Introduzca la lista de productos");
                string productos = Console.ReadLine();
                char[] comas = { ',', ';' };
                string[] substrings = productos.Split(comas, StringSplitOptions.RemoveEmptyEntries);
                List<string> lista_productos = new List<string>(substrings);
                restaurante.Crear_pedido(nombre_mesero, lista_productos, numero_mesa);
                Console.WriteLine("Su pedido fue creado con exito");
                Guardar_Archivo();

            }
            else if(opcion == "2")
            {
                Console.WriteLine("Introduzca el pedido que quiere liquidar");
                string pedido = Console.ReadLine();
                int numero_pedido = Int32.Parse(pedido);
                float valor_pedido = restaurante.Liquidar_pedido(numero_pedido);
                Console.WriteLine($"El valor total de su pedido es {valor_pedido}");
                Guardar_Archivo();
            }
            else if(opcion == "3")
            {
                Console.WriteLine("Introduzca el pedido al cual quiere agregarle un producto adicional");
                string pedido = Console.ReadLine();
                int numero_pedido = Int32.Parse(pedido);
                Console.WriteLine("Introduzca el producto que quiere agregar");
                string producto = Console.ReadLine();
                restaurante.Agregar_producto_pedido(numero_pedido, producto);
                Console.WriteLine("Producto agregado con exito");
                Guardar_Archivo();

            }
            else if(opcion == "4")
            {
                Console.WriteLine("Introduzca el pedido al cual quiere eliminarle un producto");
                string pedido = Console.ReadLine();
                int numero_pedido = Int32.Parse(pedido);
                Console.WriteLine("Introduzca el producto que quiere eliminar");
                string producto = Console.ReadLine();
                restaurante.Eliminar_producto_pedido(numero_pedido, producto);
                Console.WriteLine("Producto eliminado con exito");
                Guardar_Archivo();

            }
            else
            {
                Console.WriteLine("Introduzca una opcion valida");
                this.Gestion_Mesero(nombre_mesero);
            }
        }


    }
    
}