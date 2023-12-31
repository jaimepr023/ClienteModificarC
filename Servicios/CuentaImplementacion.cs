﻿using AltaCuentaC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCuentaC.Servicios
{
    /// <summary>
    /// clase donde se encuentra toda la logica relacionada con la cuenta 
    /// <author>jpr-211123</author>
    /// </summary>
    internal class CuentaImplementacion : CuentaInterfaz
    {
        /// <summary>
        /// metodo privado que crea una cuenta nueva 
        /// <author>jpr-211123</author>
        /// </summary>
        /// <returns>Devuelve una cuentaDTO</returns>
        private CuentaDto crearCuenta()
        {
            CuentaDto cuentaAntigua = new CuentaDto();
            Console.WriteLine("Dame el ID de tu cuenta:");
            cuentaAntigua.IdCuenta = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Dame el ISBAN de su cuenta bancaria:");
            cuentaAntigua.Isban = Console.ReadLine();
            Console.WriteLine("Dame la fecha de alta de la cuenta bancaria:");
            cuentaAntigua.FechaAltaCuenta = Console.ReadLine();
            Console.WriteLine("Dame su DNI/NIE para identificarse con la cuenta:");
            cuentaAntigua.DNICliente1 = Console.ReadLine();
            Console.WriteLine("\n");
            return cuentaAntigua;
        }

        public void altaCuenta(List<CuentaDto> listaAntigua)
        {
            CuentaDto cuentaNuea = crearCuenta();
            listaAntigua.Add(cuentaNuea);
          
        }
    }
}
