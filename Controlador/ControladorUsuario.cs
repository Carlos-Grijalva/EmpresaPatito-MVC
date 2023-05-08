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

        public static void ModificarUsuario(int idUsuario, string nombre, string apellidoP, string apellidoM, string email, string celular)
        {
            Debug.WriteLine(nombre);
            ModeloUsuario.ModificarUsuario(idUsuario, nombre, apellidoP, apellidoM, email, celular);
        }

        public static void IngresarUsuario(Usuario usuario)
        {
            ModeloUsuario.IngresarSistema(usuario);
        }

        public static List<Usuario> BuscarPorCriterios(string criterios)
        {
            return ModeloUsuario.BuscarPorCriterios(criterios);
        }

        public static Usuario BuscarPorID(int ID)
        {
            return ModeloUsuario.BuscarPorID(ID);
        }
    }
}
