using AltaCuentaC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Servicios
{
    /// <summary>
    /// Interfaz donde esta la cabecera de los metodos de la cuenta y sus relaciones 
    /// <author>jpr-211123</author>
    /// </summary>
    internal interface CuentaInterfaz
    {
        /// <summary>
        /// Metodo que realiza la operacion de dar de alta una cuenta 
        /// <author>jpr-211123</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void altaCuenta(List<CuentaDto> listaAntigua);
    }
}
