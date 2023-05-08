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
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = (from x in modeloEntity.Usuarios
                                 where x.idUsuario == idUsuario
                                 select x).First();
                
                modeloEntity.Usuarios.Remove(resultado);
                _ = modeloEntity.SaveChanges();
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

        public static Usuario BuscarPorID(int idUsuario)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = (from x in modeloEntity.Usuarios
                                 where x.idUsuario == idUsuario
                                 select x).First();
                Debug.WriteLine(resultado);
                return resultado;
            }
        }
        public static void ModificarUsuario(int idUsuario, string nombre, string apellidoP, string apellidoM, string email, string celular)
        {
            
            //var resultado = BuscarPorID(idUsuario);
            int ID = idUsuario;
            string NOMBRE = nombre;
            string APELLIDO_P = apellidoP;
            string APELLIDO_M = apellidoM;
            string EMAIL = email;
            string CELULAR = celular;

            
            /*
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = modeloEntity.Usuarios.Find(idUsuario);

                  resultado.Nombre = NOMBRE;
                  resultado.ApellidoPaterno = APELLIDO_P;
                    resultado.ApellidoMaterno = APELLIDO_M;
                //resultado.Contrasena = actulizarUsuario.Contrasena;
                resultado.Email = EMAIL;
                    resultado.Celular = CELULAR;

                    modeloEntity.Usuarios.Attach(resultado);
                    modeloEntity.SaveChanges();
                Debug.WriteLine("Despues de modificar");
             }
            
            */

            
            /*
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                //var usuarioAModificar = modeloEntity.Usuarios.SingleOrDefault(u => u.idUsuario == idUsuario);
                var usuarioAModificar = modeloEntity.Usuarios.Find(idUsuario);
                if (usuarioAModificar != null)
                {
                    //Debug.WriteLine("ModificarUsuario::"+idUsuario + '\n' + NOMBRE + '\n' + APELLIDO_P + '\n' + APELLIDO_M + '\n' + EMAIL);
                    usuarioAModificar.Nombre = nombre;
                    usuarioAModificar.ApellidoPaterno = apellidoP;
                    usuarioAModificar.ApellidoMaterno = apellidoM;
                    usuarioAModificar.Email = email;
                    usuarioAModificar.Celular = celular;
                    modeloEntity.Usuarios.Attach(usuarioAModificar);
                    modeloEntity.SaveChanges();
                }
            }
            */
            
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                //var usuarioAModificar = modeloEntity.Usuarios.SingleOrDefault(u => u.idUsuario == idUsuario);
                var usuarioAModificar = modeloEntity.Usuarios.Find(idUsuario);
                if (usuarioAModificar != null)
                {
                    if (nombre == null)
                    {
                        Debug.WriteLine(nombre + " <- Este es el nombre");
                    }
                    //Debug.WriteLine(nombre + " <- Este es el nombre");
                    //Debug.WriteLine("ModificarUsuario::"+idUsuario + '\n' + NOMBRE + '\n' + APELLIDO_P + '\n' + APELLIDO_M + '\n' + EMAIL);
                    usuarioAModificar.Nombre = nombre.ToString();
                    usuarioAModificar.ApellidoPaterno = apellidoP.ToString();
                    usuarioAModificar.ApellidoMaterno = apellidoM.ToString();
                    usuarioAModificar.Email = email.ToString();
                    usuarioAModificar.Celular = celular.ToString();
                    //modeloEntity.Usuarios.Attach(usuarioAModificar);
                    modeloEntity.SaveChanges();
                }
            }




        }

        public static void CambiarEstadoPorID(Usuario eliminarUsuario)
        {
            var resultado = BuscarPorID(eliminarUsuario.idUsuario);

           
        }


    }

}
