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
    
    public partial class usuarios_admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios_admin()
        {
            this.donacions = new HashSet<donacion>();
            this.prestamoes = new HashSet<prestamo>();
        }
    
        public int idUsuario_Admin { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string pass { get; set; }
        public string usuario { get; set; }
        public Nullable<int> telefono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<donacion> donacions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prestamo> prestamoes { get; set; }
    }
}
