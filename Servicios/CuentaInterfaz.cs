using AltaCuentaC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Servicios
{
    internal interface CuentaInterfaz
    {
        public void altaCuenta(List<CuentaDto> listaAntigua);
    }
}
