using Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public static List<Cuenta> BuscarPorCriterios(string criterios)
        {
            return ModeloCuenta.BuscarPorCriterios(criterios);
        }

        public static List<Cuenta> BuscarID(int idCuenta)
        {
            return ModeloCuenta.BuscarID(idCuenta);
        }

        public static void EliminarCuenta(int idCuenta)
        {
            ModeloCuenta.EliminarCuenta(idCuenta);
        }

        public static Cuenta BuscarPorID(int idCuenta)
        {
            return ModeloCuenta.BuscarPorID(idCuenta);
        }

        public static void ModificarCuenta(Cuenta cuenta)
        {
            ModeloCuenta.ModificarCuenta(cuenta);
        }

        public static List<int> MostrarIDs()
        {
            return ModeloCuenta.MostrarIDs();
        }

    }
}
