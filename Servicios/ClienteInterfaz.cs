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

        /// <summary>
        /// Metodo que modifica un cliente 
        /// <author> jpr-29-11-2023</author>
        /// </summary>
        /// <param name="ListaModCliente"></param>
        public void modificarCliente(List<ClienteDto> ListaModCliente);

        /// <summary>
        /// metododque borra un cliente
        /// <author> jpr-29-11-2023</author>
        /// </summary>
        /// <param name="ListaPaBorrar"></param>
        public void borrarCliente(List<ClienteDto> ListaPaBorrar);
    }
}
