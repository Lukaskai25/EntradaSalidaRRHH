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
    
    public partial class ComentariosRequerimientoEquipoInfo
    {
        public int IDComentariosRequerimientoEquipo { get; set; }
        public string Comentario { get; set; }
        public int RequerimientoEquipoID { get; set; }
        public int UsuarioID { get; set; }
        public string Usuario { get; set; }
        public System.DateTime Fecha { get; set; }
        public bool EstadoComentarioRequerimientoEquipo { get; set; }
        public string TextoEstadoComentarioRequerimientoEquipo { get; set; }
        public string Hora { get; set; }
    }
}
