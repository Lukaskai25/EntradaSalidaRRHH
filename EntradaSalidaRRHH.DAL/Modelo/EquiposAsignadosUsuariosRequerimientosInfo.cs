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
    
    public partial class EquiposAsignadosUsuariosRequerimientosInfo
    {
        public int IDDetalleCodificacionEquipo { get; set; }
        public int CodificacionEquipoID { get; set; }
        public Nullable<int> UsuarioCodificadorID { get; set; }
        public string UsuarioCodificador { get; set; }
        public Nullable<System.DateTime> FechaCodificacionEquipo { get; set; }
        public Nullable<bool> EstadoCodificacionEquipo { get; set; }
        public string TextoEstadoCodificacionEquipo { get; set; }
        public Nullable<int> RequerimientoEquipoID { get; set; }
        public Nullable<int> UsuarioSolicitanteID { get; set; }
        public string NombresSolicitanteRequerimiento { get; set; }
        public Nullable<bool> Asignado { get; set; }
        public Nullable<System.DateTime> FechaAsignacion { get; set; }
        public string TextoAsignadoRequerimientoEquipo { get; set; }
        public Nullable<bool> Aprobado { get; set; }
        public Nullable<System.DateTime> FechaAprobacion { get; set; }
        public string TextoAprobadoRequerimientoEquipo { get; set; }
        public Nullable<int> UsuarioID { get; set; }
        public string NombresUsuarioEquipoAsignado { get; set; }
        public string Factura { get; set; }
        public int EquipoID { get; set; }
        public string NombreEquipo { get; set; }
        public Nullable<int> Proveedor { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public string Codigo { get; set; }
        public string SerieEquipo { get; set; }
        public System.DateTime FechaCompra { get; set; }
        public string Observaciones { get; set; }
    }
}
