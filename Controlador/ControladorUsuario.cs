using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
   public static class ControladorUsuario
    {
        public static void GuardarUsuario(Usuario nuevoUsuario)
        {
             ModeloUsuario.GuardarUsuario(nuevoUsuario);
        }

        public static void EliminarUsuario(int idUsuario)
        {
            ModeloUsuario.EliminarUsuario(idUsuario);
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            Debug.WriteLine("Paso por ControladorUsuario/ModificarUsuario");
            ModeloUsuario.ModificarUsuario(usuario);
        }

        public static void IngresarUsuario(Usuario usuario)
        {
            ModeloUsuario.IngresarSistema(usuario);
        }

        public static List<Usuario> BuscarPorCriterios(string criterios)
        {
            return ModeloUsuario.BuscarPorCriterios(criterios);
        }

        public static List<Usuario> BuscarID(int idUsuario)
        {
            return ModeloUsuario.BuscarID(idUsuario);
        }
        public static Usuario BuscarPorID(int ID)
        {
            return ModeloUsuario.BuscarPorID(ID);
        }

        public static List<int> MostrarIDs()
        {
            return ModeloUsuario.MostrarIDs();
        }
    }
}
