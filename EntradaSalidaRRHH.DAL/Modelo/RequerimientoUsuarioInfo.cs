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
    
    public partial class RequerimientoUsuarioInfo
    {
        public int IDRequerimientoEquipoUsuario { get; set; }
        public int EquipoID { get; set; }
        public string NombreEquipo { get; set; }
        public string DescripcionEquipo { get; set; }
        public Nullable<int> Tipo { get; set; }
        public string TextoCatalogoTipo { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<int> Proveedor { get; set; }
        public string TextoCatalogoProveedor { get; set; }
        public string IDsCaracteristicas { get; set; }
        public string Caracteristicas { get; set; }
        public string Observaciones { get; set; }
        public Nullable<bool> EstadoEquipo { get; set; }
        public string TextoEstadoEquipo { get; set; }
        public int RequerimientoEquipoID { get; set; }
        public Nullable<System.DateTime> FechaSolicitud { get; set; }
        public Nullable<int> UsuarioID { get; set; }
        public Nullable<int> UsuarioSolicitanteID { get; set; }
        public string NombresSolicitante { get; set; }
        public Nullable<bool> EstadoRequerimientoEquipo { get; set; }
        public string TextoEstadoRequerimientoEquipo { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresApellidos { get; set; }
        public string Username { get; set; }
        public Nullable<int> Area { get; set; }
        public string TextoCatalogoArea { get; set; }
        public Nullable<int> Departamento { get; set; }
        public string TextoCatalogoDepartamento { get; set; }
        public Nullable<int> Cargo { get; set; }
        public string TextoCatalogoCargo { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public Nullable<int> Pais { get; set; }
        public string TextoCatalogoPais { get; set; }
        public Nullable<int> Ciudad { get; set; }
        public string TextoCatalogoCiudad { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Clave { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public Nullable<int> IdRol { get; set; }
        public string NombreRol { get; set; }
        public string DescripcionRol { get; set; }
        public Nullable<bool> EstadoRol { get; set; }
        public string TextoEstadoRol { get; set; }
        public Nullable<bool> EstadoUsuario { get; set; }
        public string TextoEstadoUsuario { get; set; }
        public Nullable<bool> Asignado { get; set; }
        public Nullable<System.DateTime> FechaAsignacion { get; set; }
        public string TextoAsignadoRequerimientoEquipo { get; set; }
        public Nullable<bool> Aprobado { get; set; }
        public Nullable<System.DateTime> FechaAprobacion { get; set; }
        public string TextoAprobadoRequerimientoEquipo { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<int> TipoContrato { get; set; }
        public string TextoCatalogoTipoContrato { get; set; }
    }
}
