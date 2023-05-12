using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public static class ModeloCuenta
    {
        public static void guardarCuenta(Cuenta cuenta)
        {
            using(var modeloEntity = new EmpresaPatitoEntities())
            {
                modeloEntity.Cuentas.Add(cuenta);
                _ = modeloEntity.SaveChanges();
            }
        }

        public static List<Cuenta> BuscarPorCriterios(string criterios)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = (from x in modeloEntity.Cuentas
                                 where x.idUsuario.ToString().Contains(criterios) |
                                 x.Saldo.ToString().Contains(criterios) |
                                 x.NumeroCuenta.Contains(criterios.ToString())
                                 select x).ToList();

                return resultado;
            }
        }

        public static List<Cuenta> BuscarID(int idCuenta)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = (from x in modeloEntity.Cuentas
                                 where x.idCuenta == idCuenta
                                 select x).ToList();
                return resultado;
            }
        }

        public static void EliminarCuenta(int idCuenta)
        {
            try
            {
                using (var modeloEntity = new EmpresaPatitoEntities())
                {
                    var resultado = modeloEntity.Cuentas.Find(idCuenta);
                    modeloEntity.Cuentas.Remove(resultado);
                    modeloEntity.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        public static Cuenta BuscarPorID(int idCuenta)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = modeloEntity.Cuentas.Find(idCuenta);
                return resultado;
            }
        }

        public static void ModificarCuenta(Cuenta cuenta)
        {
            try
            {
                using (var modeloEntity = new EmpresaPatitoEntities())
                {
                    var resultado = modeloEntity.Cuentas.Find(cuenta.idCuenta);
                    resultado.idUsuario = cuenta.idUsuario;
                    resultado.Saldo = cuenta.Saldo;
                    resultado.NumeroCuenta = cuenta.NumeroCuenta;
                    modeloEntity.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public static List<int> MostrarIDs()
        {
            try
            {
                using (var modeloEntity = new EmpresaPatitoEntities())
                {
                    
                    var resultado = modeloEntity.Cuentas.Select(e => e.idCuenta).ToList();
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
