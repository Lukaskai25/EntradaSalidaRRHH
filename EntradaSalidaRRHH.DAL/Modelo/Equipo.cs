//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntradaSalidaRRHH.DAL.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipo
    {
        public int IDEquipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Tipo { get; set; }
        public string Observaciones { get; set; }
        public bool Estado { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public int Proveedor { get; set; }
    }
}
