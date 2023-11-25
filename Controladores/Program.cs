//funcionalidad partiendo de la actividad anterior, crear la funcionalidad de dar de alta una cuenta bancaria(campo que identifique a que cliente pertenece la cuenta bancaria, tiene que haber al menos un campo)
//campos--> idcuenta, ISBAN, codigo switch de la intedidad al que pertenece(CTE), indica a que cliente pertenece(cualquiera vale), fecha alta y fecha baja

using AltaCuentaC.Dtos;
using AltaCuentaC.Servicios;

namespace AltaCuentaC.Controladores
{
    /// <summary>
    /// Clase inicial de nuestra app donde esta el metodo main
    /// <author>jpr-211123</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main donde se encuentra todo el procedimiento de nuestra app
        /// <author>jpr-211123</author>
        /// </summary>
        /// <param name="args"></param>
        static public void Main(String[] args)
        {
            List<ClienteDto> cliente = new List<ClienteDto>();
            List<CuentaDto> cuenta = new List<CuentaDto>();
            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            CuentaInterfaz cci = new CuentaImplementacion();
            mi.mensajeBienvenida();

            bool cerrarMenu = false;
            int opcionUsuario;

            while (!cerrarMenu)
            {
                opcionUsuario = mi.menu();
                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Se cerrara el menu. Muchas gracias.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("A continuacion podra darse de alta.(cliente)");
                        ci.DarAltaCliente(cliente);
                        foreach(ClienteDto clienteDto in cliente)
                        {
                            Console.WriteLine(clienteDto.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("A continuacion podra modificar el cliente, confirme su DNI:");
                        string DNISEGURE=Console.ReadLine();
                        foreach (ClienteDto clientedto in cliente)
                        {
                            if (clientedto.DNI1 == DNISEGURE)
                            {
                                foreach (ClienteDto clienteDto in cliente)
                                {
                                    Console.WriteLine("¿Quieres modificar tu nombre? ");
                                    string afirmacion = Console.ReadLine();
                                    if (afirmacion == "si")
                                    {
                                        Console.WriteLine("Dame tu nombre: ");
                                        clienteDto.NombreCliente = Console.ReadLine();
                                    }

                                    Console.WriteLine("¿Quieres modificar tu apellido? ");
                                    string afirmacion1 = Console.ReadLine();
                                    if (afirmacion1 == "si")
                                    {
                                        Console.WriteLine("Dame tu apellido: ");
                                        clienteDto.ApellidosClientes = Console.ReadLine();
                                    }

                                    Console.WriteLine("¿Quieres modificar tu telefono? ");
                                    string afirmacion2 = Console.ReadLine();
                                    if (afirmacion2 == "si")
                                    {
                                        Console.WriteLine("Dame tu telefono: ");
                                        clienteDto.TLF1 = Int32.Parse(Console.ReadLine());

                                    }

                                    Console.WriteLine("¿Quieres modificar tu fecha de nacimiento? ");
                                    string afirmacion3 = Console.ReadLine();
                                    if (afirmacion3 == "si")
                                    {
                                        Console.WriteLine("Dame tu fecha de nacimiento: ");
                                        clienteDto.FechaNacimiento = Console.ReadLine();
                                    }

                                    Console.WriteLine("¿Quieres modificar tu fecha de alta? ");
                                    string afirmacion4 = Console.ReadLine();
                                    if (afirmacion4 == "si")
                                    {
                                        Console.WriteLine("Dame tu fecha de alta: ");
                                        clienteDto.FechaAlta = Console.ReadLine();
                                    }  
                                }
                             

                            }
                            Console.WriteLine(clientedto.ToString());

                        }
                        break;
                    case 3:
                        Console.WriteLine("A continuacion podra dar e alta una cuenta");
                        cci.altaCuenta(cuenta);
                        foreach(CuentaDto cuentaDto in cuenta)
                        {
                            Console.WriteLine(cuentaDto.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("[INFOS]- Error no ha elegido ninguna de las opciones");
                        break;
                }
            }
        }
    }
}