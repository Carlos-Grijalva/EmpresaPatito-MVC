//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarjeta
    {
        public int idTarjeta { get; set; }
        public string nombreEntidad { get; set; }
        public Nullable<System.DateTime> fechaCaducidad { get; set; }
        public string marca { get; set; }
        public int idCuenta { get; set; }
        public string numeroTarjeta { get; set; }
        public Nullable<int> cvv { get; set; }
    
        public virtual Cuenta Cuenta { get; set; }
    }
}
