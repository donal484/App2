//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarcenterWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class REPUESTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REPUESTOS()
        {
            this.SERVICIO_REPUESTO = new HashSet<SERVICIO_REPUESTO>();
        }
    
        public decimal ID_REPUESTO { get; set; }
        public string DESC_MENSAJE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO_REPUESTO> SERVICIO_REPUESTO { get; set; }
    }
}
