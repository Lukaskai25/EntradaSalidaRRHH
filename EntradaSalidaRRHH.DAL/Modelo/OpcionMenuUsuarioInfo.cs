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
    
    public partial class OpcionMenuUsuarioInfo
    {
        public int IdMenu { get; set; }
        public string NombreMenu { get; set; }
        public Nullable<int> IdMenuPadre { get; set; }
        public string carpeta { get; set; }
        public string opcion { get; set; }
        public Nullable<int> hijos { get; set; }
        public string permisos { get; set; }
        public Nullable<int> OrdenMenu { get; set; }
    }
}
