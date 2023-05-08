using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public static class ModeloTarjeta
    {
        public static void GuardarTarjeta(Tarjeta tarjeta)
        {
            using (var modeloEntity = new EmpresaPatitoEntities())
            {
                modeloEntity.Tarjetas.Add(tarjeta);
                _ = modeloEntity.SaveChanges();
            }
        }
    }
}
