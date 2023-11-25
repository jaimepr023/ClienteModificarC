using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Dtos
{
    /// <summary>
    /// Clase donde se encuentra los atributos/caracteristicas en relacion con el cliente
    /// <author>jpr-211123</author>
    /// </summary>
    internal class ClienteDto
    {
        long idCliente;

        string nombreCliente;

        string apellidosClientes;

        string DNI;

        int TLF;

        string fechaNacimiento;

        string fechaAlta;

        string fechaBaja = "12/31/9999";

       
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosClientes { get => apellidosClientes; set => apellidosClientes = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public int TLF1 { get => TLF; set => TLF = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }


        /// <summary>
        /// Constructores de los atributos del cliente 
        /// <author>jpr-211123</author>
        /// </summary>
        public ClienteDto()
        {

        }

        /// <summary>
        /// Metodo ToString para poder imprimir despues la lista y sus valores
        /// <author>jpr-211123</author>
        /// </summary>
        /// <returns>las caracteristicas del cliente </returns>
        override
        public string ToString()
        {
            string todoCliente =
                "ID-->" + idCliente +"\n"+
                "Nombre--> " + nombreCliente + "\n"
                + "Apellidos--> " + apellidosClientes + "\n"
                + "DNI/NIE--> " + DNI + "\n"
                + "Telefono--> " + TLF + "\n"
                + "Fecha de Nacimiento--> " + fechaNacimiento + "\n"
                + "Fecha de Alta--> " + fechaAlta + "\n"
                 + "Fecha de Baja--> " + fechaBaja + "\n";

            return todoCliente;
        }
    }
}
