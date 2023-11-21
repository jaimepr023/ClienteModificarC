using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Servicios
{
    /// <summary>
    /// Implementacion que implementa la interfaz del menu
    /// <author>jpr-211123</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            Console.WriteLine("Bienvenido al Banco\n");
        }

        public int menu()
        {
            int seleccionarOpcion;
            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("............................");
            Console.WriteLine("Opcion 0. Cerrar menu.");
            Console.WriteLine("Opcion 1. Dar de alta un cliente.");
            Console.WriteLine("Opcion 2. Dar de alta una cuenta bancaria.");
            Console.WriteLine("............................");

            seleccionarOpcion = Console.ReadKey(true).KeyChar - ('0');
            return seleccionarOpcion;
        }
    }
}
