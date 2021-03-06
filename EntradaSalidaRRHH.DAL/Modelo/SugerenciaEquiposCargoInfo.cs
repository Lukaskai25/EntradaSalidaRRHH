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
    
    public partial class SugerenciaEquiposCargoInfo
    {
        public int IDSugerenciaEquiposCargo { get; set; }
        public int EquipoID { get; set; }
        public string NombreEquipo { get; set; }
        public string DescripcionEquipo { get; set; }
        public Nullable<int> Tipo { get; set; }
        public string TextoCatalogoTipo { get; set; }
        public string Caracteristicas { get; set; }
        public string IDsCaracteristicas { get; set; }
        public string ObservacionesEquipo { get; set; }
        public Nullable<bool> EstadoEquipo { get; set; }
        public string TextoEstadoEquipo { get; set; }
        public int CargoSugerenciaEquipos { get; set; }
        public string TextoCatalogoCargoSugerenciaEquipo { get; set; }
        public string Programas { get; set; }
        public string IDsProgramas { get; set; }
        public string ObservacionesSugerenciaEquipoCargo { get; set; }
        public int UsuarioID { get; set; }
        public bool EstadoSugerenciaEquiposCargo { get; set; }
        public string NombresUsuario { get; set; }
        public string ApellidosUsuario { get; set; }
        public string NombresApellidosUsuario { get; set; }
        public string identificacion { get; set; }
        public string username { get; set; }
        public Nullable<int> Departamento { get; set; }
        public Nullable<int> Pais { get; set; }
        public Nullable<int> Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Clave { get; set; }
        public Nullable<bool> TextoEstadoUsuario { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<int> CargoUsuario { get; set; }
        public Nullable<int> Cargo { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public Nullable<int> IdRol { get; set; }
        public string NombreRol { get; set; }
        public string DescripcionRol { get; set; }
        public Nullable<bool> EstadoRol { get; set; }
        public Nullable<bool> ResetClave { get; set; }
        public Nullable<bool> ValidacionCorreo { get; set; }
        public string TokenValidacionCorreo { get; set; }
        public string TextEstadoSugerenciaEquiposCargo { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<int> Proveedor { get; set; }
        public string TextoCatalogoProveedor { get; set; }
        public Nullable<int> EmpresaSugerenciaEquipos { get; set; }
    }
}
