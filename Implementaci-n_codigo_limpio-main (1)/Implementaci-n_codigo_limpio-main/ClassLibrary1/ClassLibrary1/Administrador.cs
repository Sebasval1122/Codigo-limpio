using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Administrador
    {
        public string Clave_Admin = "12345";
        public string Buscar_mesero(string nombre_mesero)
        {
            Mesero mesero_encontrado = null;
            foreach (Mesero mesero in Meseros)
            {
                if(mesero.Nombre == nombre_mesero)
                {
                   mesero_encontrado = mesero;
                }
            }
            return mesero_encontrado.ToString();
        }
    }
}
