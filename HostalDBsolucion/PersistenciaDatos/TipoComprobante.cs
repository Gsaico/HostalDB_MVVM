//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersistenciaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoComprobante
    {
        public TipoComprobante()
        {
            this.comprobante = new HashSet<comprobante>();
        }
    
        public int idcomprobante { get; set; }
        public string nombrecomprobante { get; set; }
    
        public virtual ICollection<comprobante> comprobante { get; set; }
    }
}