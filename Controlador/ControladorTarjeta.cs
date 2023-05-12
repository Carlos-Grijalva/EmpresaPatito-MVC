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

        public static List<Tarjeta> BuscarPorCriterios(string criterios)
        {
            return ModeloTarjeta.BuscarPorCriterios(criterios);
        }

        public static List<Tarjeta> BuscarID(int idTarjeta)
        {
            return ModeloTarjeta.BuscarID(idTarjeta);
        }

        public static void EliminarTarjeta(int idTarjeta)
        {
            ModeloTarjeta.EliminarTarjeta(idTarjeta);
        }

        public static Tarjeta BuscarPorID(int idTarjeta)
        {
            return ModeloTarjeta.BuscarPorID(idTarjeta);
        }

        public static void ModificarTarjeta(Tarjeta tarjeta)
        {
            ModeloTarjeta.ModificarTarjeta(tarjeta);
        }

        public static List<int> MostrarIDs()
        {
            return ModeloTarjeta.MostrarIDs();
        }
    }
}
