using AltaCuentaC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Servicios
{
    internal interface ClienteInterfaz
    {
        public void DarAltaCliente(List<ClienteDto> ListaAntigua);
    }
}
