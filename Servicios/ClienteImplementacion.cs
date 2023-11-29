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
            bool cerrarMenuModificar = false;
            string DNISEGURE = Console.ReadLine();
            foreach (ClienteDto clientedto in ListaModCliente)
            {
                if (DNISEGURE.Equals(clientedto.DNI1))
                {
                    while (!cerrarMenuModificar)
                    {
                        int opcion = menuModificar();
                        switch (opcion)
                        {
                            case 0:
                                cerrarMenuModificar=true;
                                break;
                            case 1:
                                Console.WriteLine("Dame tu nombre: ");
                                clientedto.NombreCliente = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Dame tu apellido: ");
                                clientedto.ApellidosClientes = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Dame tu telefono: ");
                                clientedto.TLF1 = Int32.Parse(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Dame tu fecha de nacimiento: ");
                                clientedto.FechaNacimiento = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("[INFOS]-Error, no has elegido ninguna opcion");
                                break;

                        }
                    }
                }
                Console.WriteLine(clientedto.ToString());

            }

        }
        
        /// <summary>
        /// Metodo privado para mostra en el menu que nos da la opcion de que campos podemos modificar 
        /// <author> jpr-29-11-2023</author>
        /// </summary>
        /// <returns>opcion que elegimos del menu</returns>
        private int menuModificar()
        {
            int opcion;
            Console.WriteLine("Opcion 0. Cerrar Menu.");
            Console.WriteLine("Opcion 1. Modificar Nombre.");
            Console.WriteLine("Opcion 2. Modificar Apellidos.");
            Console.WriteLine("Opcion 3. Modificar telefono.");
            Console.WriteLine("Opcion 4. Modificar Fecha de nacimiento.");
            Console.WriteLine("¿Que opcion quieres? ");
            opcion =Console.ReadKey(true).KeyChar-'0';
            return opcion;
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
                    break;

                }
            }
            ListaPaBorrar.Remove(borrarCliente);
        }

   
    }
}
