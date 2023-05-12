using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public static class ModeloUsuario
    {

        public static void GuardarUsuario(Usuario nuevoUsuario)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                modeloEntity.Usuarios.Add(nuevoUsuario);
                _ = modeloEntity.SaveChanges();
            }
        }

        public static void EliminarUsuario(int idUsuario)
        {
            try
            {
                using (var modeloEntity = new EmpresaPatitoEntities())
                {
                    var resultado = modeloEntity.Usuarios.Find(idUsuario);
                    modeloEntity.Usuarios.Remove(resultado);
                    modeloEntity.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            
        }

        public static void IngresarSistema(Usuario preUsuario)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado =
                    (from x in modeloEntity.Usuarios
                     where x.Email == preUsuario.Email &
                     x.Contrasena == preUsuario.Contrasena
                     select x).FirstOrDefault();

                if (resultado == null)
                {
                    throw new Exception("Usuario y/o contrasena no existen.");
                }
            }
        }


        public static List<Usuario> BuscarPorCriterios(string criterios)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = (from x in modeloEntity.Usuarios
                                 where x.Nombre.Contains(criterios) |
                                 x.ApellidoPaterno.Contains(criterios) |
                                 x.ApellidoMaterno.Contains(criterios) |
                                 x.Celular.Contains(criterios) |
                                 x.Email.Contains(criterios)
                                 orderby x.Nombre ascending
                                 select x).ToList();

                return resultado;
            }
        }

        public static List<Usuario> BuscarID(int idUsuario)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = (from x in modeloEntity.Usuarios
                                 where x.idUsuario == idUsuario
                                 select x).ToList();
                return resultado;
            }
        }

        public static Usuario BuscarPorID(int idUsuario)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = modeloEntity.Usuarios.Find(idUsuario);
                return resultado;
            }
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = modeloEntity.Usuarios.Find(usuario.idUsuario);
                resultado.Nombre = usuario.Nombre;
                resultado.ApellidoPaterno = usuario.ApellidoPaterno;
                resultado.ApellidoMaterno = usuario.ApellidoMaterno;
                resultado.Email = usuario.Email;
                resultado.Celular = usuario.Celular;
                modeloEntity.SaveChanges();
            }

        }

        public static void CambiarEstadoPorID(Usuario eliminarUsuario)
        {
            var resultado = BuscarPorID(eliminarUsuario.idUsuario);
        }

        public static List<int> MostrarIDs()
        {
            try
            {
                using (var modeloEntity = new EmpresaPatitoEntities())
                {
                    var resultado = modeloEntity.Usuarios.Select(e => e.idUsuario).ToList();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new List<int>();
            }
        }
    }

}
