using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace ClassLibrary1{
    public class Identificador: Gestor
    {
        public void Indentificar_Mesero()
        {
            Console.WriteLine("Porfavor introduzca su nombre para ser identificado:");
            string nombre_mesero = Console.ReadLine();
            foreach (Mesero mesero in Restaurante.Meseros)
            {
                if (mesero.Nombre == nombre_mesero)
                {
                    Console.WriteLine($"Bienvenido {nombre_mesero}");
                    Gestion_Mesero(nombre_mesero);
                }
                else
                {
                    Console.WriteLine("El nombre introducido no corresponde a ningun trabajador");
                    this.Indentificar_Mesero();
                }
            }
        }

        public void Indentificar_administrador()
        {
            Console.WriteLine("Introduzca la contraseña de admin:");
            string contraseña = Console.ReadLine();
            if (contraseña == Restaurante.Administrador)
            {
                Console.WriteLine("Acceso concedido");
                Gestion_Administrador();
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
                this.Indentificar_administrador();
            }

        }

        public void Identificar_usuario()
        {

            Console.WriteLine("Bienvenido, identifique que clase de usuario es:");
            Console.WriteLine("1. Administrador");
            Console.WriteLine("2. Mesero");
            string tipo_usuario = Console.ReadLine();
            if (tipo_usuario == "1")
            {
               Indentificar_administrador();
            }
            else if(tipo_usuario == "2")
            {
                Indentificar_Mesero();
            }
        }
    }
}