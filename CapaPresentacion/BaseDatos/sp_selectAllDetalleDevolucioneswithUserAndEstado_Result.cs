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
    
    public partial class sp_selectAllDetalleDevolucioneswithUserAndEstado_Result
    {
        public int idPrestamoDetalle { get; set; }
        public int id_prestamo { get; set; }
        public int id_libro { get; set; }
        public string nombre { get; set; }
        public int id_estado { get; set; }
        public string nombreEstado { get; set; }
        public Nullable<System.DateTime> fecha_prestamo { get; set; }
        public Nullable<System.DateTime> fecha_devolucion { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public string usuario { get; set; }
    }
}