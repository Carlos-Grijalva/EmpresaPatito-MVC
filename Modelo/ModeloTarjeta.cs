using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public static class ModeloTarjeta
    {
        public static void GuardarTarjeta(Tarjeta tarjeta)
        {
            try
            {
                using (var modeloEntity = new EmpresaPatitoEntities())
                {
                    modeloEntity.Tarjetas.Add(tarjeta);
                    modeloEntity.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }

        public static List<Tarjeta> BuscarPorCriterios(string criterios)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = (from x in modeloEntity.Tarjetas
                                 where x.idTarjeta.ToString().Contains(criterios) |
                                 x.nombreEntidad.ToString().Contains(criterios) |
                                 x.numeroTarjeta.Contains(criterios) |
                                 x.marca.Contains(criterios) |
                                 x.fechaCaducidad.ToString().Contains(criterios) |
                                 x.cvv.ToString().Contains(criterios) |
                                 x.idCuenta.ToString().Contains(criterios)
                                 select x).ToList();

                return resultado;
            }
        }

        public static List<Tarjeta> BuscarID(int idTarjeta)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = (from x in modeloEntity.Tarjetas
                                 where x.idTarjeta == idTarjeta
                                 select x).ToList();
                return resultado;
            }
        }

        public static void EliminarTarjeta(int idTarjeta)
        {
            try
            {
                using (var modeloEntity = new EmpresaPatitoEntities())
                {
                    var resultado = modeloEntity.Tarjetas.Find(idTarjeta);
                    modeloEntity.Tarjetas.Remove(resultado);
                    modeloEntity.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }

        public static Tarjeta BuscarPorID(int idTarjeta)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                var resultado = modeloEntity.Tarjetas.Find(idTarjeta);
                return resultado;
            }
        }

        public static void ModificarTarjeta(Tarjeta tarjeta)
        {
            try
            {
                using (var modeloEntity = new EmpresaPatitoEntities())
                {
                    var resultado = modeloEntity.Tarjetas.Find(tarjeta.idTarjeta);
                    resultado.idCuenta = tarjeta.idCuenta;
                    resultado.nombreEntidad = tarjeta.nombreEntidad;
                    resultado.numeroTarjeta = tarjeta.numeroTarjeta;
                    resultado.fechaCaducidad = tarjeta.fechaCaducidad;
                    resultado.marca = tarjeta.marca;
                    resultado.cvv = tarjeta.cvv;
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
                    var resultado = modeloEntity.Tarjetas.Select(e => e.idTarjeta).ToList();
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
