//funcionalidad partiendo de la actividad anterior, crear la funcionalidad de dar de alta una cuenta bancaria(campo que identifique a que cliente pertenece la cuenta bancaria, tiene que haber al menos un campo)
//campos--> idcuenta, ISBAN, codigo switch de la intedidad al que pertenece(CTE), indica a que cliente pertenece(cualquiera vale), fecha alta y fecha baja

using AltaCuentaC.Dtos;
using AltaCuentaC.Servicios;

namespace AltaCuentaC.Controladores
{
    class program
    {
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
                        ci.DarAltaCliente(cliente);
                        foreach(ClienteDto clienteDto in cliente)
                        {
                            Console.WriteLine(clienteDto.ToString());
                        }
                        break;
                    case 2:
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