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
    
    public partial class UsuarioInfo
    {
        public int IdUsuario { get; set; }
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
        public Nullable<bool> ResetClave { get; set; }
        public Nullable<bool> ValidacionCorreo { get; set; }
        public Nullable<bool> Activo { get; set; }
        public string TokenValidacionCorreo { get; set; }
        public string MailCorporativo { get; set; }
        public Nullable<int> CiudadUbicacionEmpresa { get; set; }
        public string TextoCatalogoCiudadUbicacionEmpresa { get; set; }
        public string TextoActivoUsuario { get; set; }
    }
}
