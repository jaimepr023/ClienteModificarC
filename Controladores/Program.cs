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
            //Listas
            List<ClienteDto> ListaCliente = new List<ClienteDto>();
            List<CuentaDto> ListaCuenta = new List<CuentaDto>();
            
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
                        ci.DarAltaCliente(ListaCliente);
                        foreach(ClienteDto clienteDto in ListaCliente)
                        {
                            Console.WriteLine(clienteDto.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("A continuacion podra modificar el cliente, confirme su DNI:");
                        ci.modificarCliente(ListaCliente);
                        break;
                    case 3:
                        Console.WriteLine("A continuacion podra dar e alta una cuenta");
                        cci.altaCuenta(ListaCuenta);
                        foreach(CuentaDto cuentaDto in ListaCuenta)
                        {
                            Console.WriteLine(cuentaDto.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("[INFOS]- Error nos ha elegido ninguna de las opciones");
                        break;
                }
            }
        }
    }
}