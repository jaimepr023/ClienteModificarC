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
        long idCuenta;

        string isban;

        string códigoSwitch = " CSI1SSXX";

        string fechaAltaCuenta;

        string fechaBajaCuenta = "12/31/9999";

        string DNICliente;

       
        public long IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string Isban { get => isban; set => isban = value; }
        public string CódigoSwitch { get => códigoSwitch; set => códigoSwitch = value; }
        public string FechaAltaCuenta { get => fechaAltaCuenta; set => fechaAltaCuenta = value; }
        public string FechaBajaCuenta { get => fechaBajaCuenta; set => fechaBajaCuenta = value; }
        public string DNICliente1 { get => DNICliente; set => DNICliente = value; }

        /// <summary>
        /// Constructores de los atributos del cliente 
        /// <author>jpr-211123</author>
        /// </summary>
        public CuentaDto()
        {

        }

        /// <summary>
        /// Metodo ToString para poder imprimir despues la lista y sus valores
        /// <author>jpr-211123</author>
        /// </summary>
        /// <returns>las caracteristicas de la cuenta </returns>
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
