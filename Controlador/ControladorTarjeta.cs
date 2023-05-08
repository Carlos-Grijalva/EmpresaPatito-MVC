using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public static class ControladorTarjeta
    {
        public static void guardarTarjeta(Tarjeta tarjeta)
        {
            ModeloTarjeta.GuardarTarjeta(tarjeta);
        }
    }
}
