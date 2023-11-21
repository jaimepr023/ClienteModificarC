using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentra la cabecera de los metodos en relacion con el menu
    /// <author>jpr-211123</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo de mostrar el mensaje de bienvenida al usuario
        /// <author>jpr-211123</author>
        /// </summary>
        public void mensajeBienvenida();

        /// <summary>
        /// Metodo que muestra por pantalla el menu de interaccion con el usuario
        /// <author>jpr-211123</author>
        /// </summary>
        /// <returns>un entero</returns>
        public int menu();
    }
}
