using AltaCuentaC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Servicios
{
    /// <summary>
    /// Implementacion que implementa la interfaz de cliente
    /// <author>jpr-211123</author>
    /// </summary>
    internal class ClienteImplementacion : ClienteInterfaz
    {

        /// <summary>
        /// metodo privado para crear un cliente 
        /// <author>jpr-211123</author>
        /// </summary>
        /// <returns>cliente</returns>
        private ClienteDto crearCliente()
        {
            ClienteDto cliente = new ClienteDto();
            Console.WriteLine("Dame el ID del cliente: ");
            cliente.IdCliente = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Dame tu nombre: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Dame tus apellidos: ");
            cliente.ApellidosClientes = Console.ReadLine();
            Console.WriteLine("Dame tu DNI/NIE");
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

       
        public void modificarCliente(List<ClienteDto> ListaModCliente)
        {
            string DNISEGURE = Console.ReadLine();
            foreach (ClienteDto clientedto in ListaModCliente)
            {
                if (DNISEGURE.Equals(clientedto.DNI1))
                {

                    Console.WriteLine("¿Quieres modificar tu nombre? ");
                    string afirmacion = Console.ReadLine();
                    if (afirmacion == "si")
                    {
                        Console.WriteLine("Dame tu nombre: ");
                        clientedto.NombreCliente = Console.ReadLine();
                    }

                    Console.WriteLine("¿Quieres modificar tu apellido? ");
                    string afirmacion1 = Console.ReadLine();
                    if (afirmacion1 == "si")
                    {
                        Console.WriteLine("Dame tu apellido: ");
                        clientedto.ApellidosClientes = Console.ReadLine();
                    }

                    Console.WriteLine("¿Quieres modificar tu telefono? ");
                    string afirmacion2 = Console.ReadLine();
                    if (afirmacion2 == "si")
                    {
                        Console.WriteLine("Dame tu telefono: ");
                        clientedto.TLF1 = Int32.Parse(Console.ReadLine());

                    }

                    Console.WriteLine("¿Quieres modificar tu fecha de nacimiento? ");
                    string afirmacion3 = Console.ReadLine();
                    if (afirmacion3 == "si")
                    {
                        Console.WriteLine("Dame tu fecha de nacimiento: ");
                        clientedto.FechaNacimiento = Console.ReadLine();
                    }

                    Console.WriteLine("¿Quieres modificar tu fecha de alta? ");
                    string afirmacion4 = Console.ReadLine();
                    if (afirmacion4 == "si")
                    {
                        Console.WriteLine("Dame tu fecha de alta: ");
                        clientedto.FechaAlta = Console.ReadLine();
                    }



                }
                Console.WriteLine(clientedto.ToString());

            }

        }
        
            
        public void borrarCliente(List<ClienteDto> ListaPaBorrar)
        {
            ClienteDto borrarCliente = new ClienteDto();
            string Dni = Console.ReadLine();    

            foreach(ClienteDto cliente in ListaPaBorrar)
            {
                if (cliente.DNI1.Equals(Dni))
                {
                    borrarCliente = cliente;

                }
                ListaPaBorrar.Remove(borrarCliente); 
            }
        }

   
    }
}
