using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public static class ControladorCuenta
    {

        public static void guardarCuenta(Cuenta cuenta)
        {
            ModeloCuenta.guardarCuenta(cuenta);
        }
     
    }
}
