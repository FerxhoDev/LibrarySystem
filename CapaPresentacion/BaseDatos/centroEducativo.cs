//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacion.BaseDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class centroEducativo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public centroEducativo()
        {
            this.usuariosPrestamistas = new HashSet<usuariosPrestamista>();
        }
    
        public int idCentroEducativo { get; set; }
        public string nombreCentroEducativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuariosPrestamista> usuariosPrestamistas { get; set; }
    }
}