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
    
    public partial class detalle_donacion
    {
        public int idDetalle_donacion { get; set; }
        public int id_donacion { get; set; }
        public int id_libro { get; set; }
        public int cantidad { get; set; }
        public System.DateTime fehcaRegistro { get; set; }
    
        public virtual donacion donacion { get; set; }
        public virtual libro libro { get; set; }
    }
}
