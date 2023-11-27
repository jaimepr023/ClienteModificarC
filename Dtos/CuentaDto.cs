using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Dtos
{
    /// <summary>
    /// Clase donde se encuentra las caracteristicas/atributos de nuestra cuenta 
    /// <author>jpr-211123</author>
    /// </summary>
    internal class CuentaDto
    {
        long idCuenta ;

        string isban = "aaaaa";

        string códigoSwitch = " CSI1SSXX";

        string fechaAltaCuenta = "aaaaa";

        string fechaBajaCuenta = "12/31/9999";

        string DNICliente = "aaaaa";

       
        public long IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string Isban { get => isban; set => isban = value; }
        public string CódigoSwitch { get => códigoSwitch; set => códigoSwitch = value; }
        public string FechaAltaCuenta { get => fechaAltaCuenta; set => fechaAltaCuenta = value; }
        public string FechaBajaCuenta { get => fechaBajaCuenta; set => fechaBajaCuenta = value; }
        public string DNICliente1 { get => DNICliente; set => DNICliente = value; }

       
        public CuentaDto()
        {

        }

       
        override
        public string ToString()
        {
            Console.WriteLine("Aqui estan todos los datos de su cuenta:\n");
            string todoCuenta = "idCuenta--> " + idCuenta + "\n"
                + "ISBAN--> " + isban + "\n"
                + "código Switch--> " + códigoSwitch + "\n"
                + "fecha de alta--> " + fechaAltaCuenta + "\n"
                + "fecha de baja--> " + fechaBajaCuenta + "\n"
                + "DNI/NIE Cliente--> " + DNICliente + "\n";
            return todoCuenta;
        }
    }
}
