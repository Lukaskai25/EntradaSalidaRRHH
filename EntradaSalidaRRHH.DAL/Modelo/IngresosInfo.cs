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
    
    public partial class IngresosInfo
    {
        public int IDIngreso { get; set; }
        public Nullable<int> TipoIngreso { get; set; }
        public string TextoCatalogoTipoIngreso { get; set; }
        public Nullable<int> Empresa { get; set; }
        public string TextoCatalogoEmpresa { get; set; }
        public Nullable<int> Area { get; set; }
        public string TextoCatalogoArea { get; set; }
        public Nullable<int> Departamento { get; set; }
        public string TextoCatalogoDepartamento { get; set; }
        public string PersonaReemplazante { get; set; }
        public string CorreoAsignado { get; set; }
        public Nullable<decimal> Sueldo { get; set; }
        public int FichaIngresoID { get; set; }
        public Nullable<int> UsuarioID { get; set; }
        public string NombresUsuario { get; set; }
        public string ApellidosUsuario { get; set; }
        public string IdentificacionUsuario { get; set; }
        public Nullable<int> Ciudad { get; set; }
        public string EmailUsuario { get; set; }
        public string TelefonoUsuario { get; set; }
        public string CelularUsuario { get; set; }
        public Nullable<int> CiudadResidencia { get; set; }
        public string TextoCatalogoCiudadResidencia { get; set; }
        public byte[] Foto { get; set; }
        public Nullable<int> Genero { get; set; }
        public string TextoCatalogoGenero { get; set; }
        public Nullable<int> Nacionalidad { get; set; }
        public string TextoCatalogoNacionalidad { get; set; }
        public Nullable<int> LugarNacimiento { get; set; }
        public string TextoCatalogoLugarNacimiento { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<int> EstadoCivil { get; set; }
        public string TextoCatalogoEstadoCivil { get; set; }
        public Nullable<int> Banco { get; set; }
        public string TextoCatalogoBanco { get; set; }
        public string NumeroCuentaBancaria { get; set; }
        public Nullable<int> TipoSangre { get; set; }
        public string TextoCatalogoTipoSangre { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaIngresoFicha { get; set; }
        public string DireccionCallePrincipal { get; set; }
        public string DireccionCalleSecundaria { get; set; }
        public string DireccionNumeroCasa { get; set; }
        public string DireccionConjuntoResidencial { get; set; }
        public string NombresContactoEmergencia { get; set; }
        public string ApellidosContactoEmergencia { get; set; }
        public Nullable<int> ParentescoContactoEmergencia { get; set; }
        public string TextoCatalogoParentescoContactoEmergencia { get; set; }
        public string TelefonoContactoEmergencia { get; set; }
        public string CelularContactoEmergencia { get; set; }
        public bool EstadoIngreso { get; set; }
        public string TextoEstadoIngreso { get; set; }
        public Nullable<int> TipoCuenta { get; set; }
        public string TextoCatalogoTipoCuenta { get; set; }
        public Nullable<int> JefeDirecto { get; set; }
        public string TextoCatalogoJefeDirecto { get; set; }
        public Nullable<int> Cargo { get; set; }
        public string TextoCatalogoCargo { get; set; }
        public Nullable<int> TipoContrato { get; set; }
        public string TextoCatalogoTipoContrato { get; set; }
        public Nullable<int> GrupoCorreo { get; set; }
        public string TextoCatalogoGrupoCorreo { get; set; }
        public string CredencialAcceso { get; set; }
        public string NombresApellidosUsuario { get; set; }
    }
}
