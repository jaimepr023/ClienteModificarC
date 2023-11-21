using AltaCuentaC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Servicios
{
    /// <summary>
    /// Interfaz donde esta la cabecera de los metodos en relacion con el cliente 
    /// <author>jpr-211123</author>
    /// </summary>
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// metodo de dar de alta un cliente
        /// <author>jpr-211123</author>
        /// </summary>
        /// <param name="ListaAntigua"></param>
        public void DarAltaCliente(List<ClienteDto> ListaAntigua);
    }
}
