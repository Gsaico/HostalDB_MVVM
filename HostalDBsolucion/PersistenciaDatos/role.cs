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
    
    public partial class role
    {
        public role()
        {
            this.user_role = new HashSet<user_role>();
        }
    
        public int role_id { get; set; }
        public string authority { get; set; }
    
        public virtual ICollection<user_role> user_role { get; set; }
    }
}
