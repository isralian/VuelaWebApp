//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VuelaWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class equipaje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipaje()
        {
            this.lineavuelo = new HashSet<lineavuelo>();
        }
    
        public int idequipaje { get; set; }
        public string cliente { get; set; }
        public Nullable<decimal> peso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lineavuelo> lineavuelo { get; set; }
    }
}
