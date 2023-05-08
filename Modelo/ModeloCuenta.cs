using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
