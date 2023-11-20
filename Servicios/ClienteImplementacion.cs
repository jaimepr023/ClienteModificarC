using AltaCuentaC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public object Int34 { get; private set; }

        private ClienteDto crearCliente()
        {
            ClienteDto cliente = new ClienteDto();
            Console.WriteLine("Dame el ID del cliente: ");
            cliente.IdCliente = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Dame tu nombre: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Dame tus apellidos: ");
            cliente.ApellidosClientes = Console.ReadLine();
            Console.WriteLine("Dame tu DNI");
            cliente.DNI1 = Console.ReadLine();
            Console.WriteLine("Dame tu numero de telefono: ");
            cliente.TLF1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame tu fecha de nacimiento: ");
            cliente.FechaNacimiento = Console.ReadLine();
            Console.WriteLine("Dame tu fecha de alta: ");
            cliente.FechaAlta = Console.ReadLine();

            return cliente;
        }

        public void DarAltaCliente(List<ClienteDto> ListaAntigua)
        {
            ClienteDto nuevoCliente = crearCliente();
            ListaAntigua.Add(nuevoCliente);
        }
    }
}
