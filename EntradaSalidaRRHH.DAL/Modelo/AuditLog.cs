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
    
    public partial class AuditLog
    {
        public int IdAuditLog { get; set; }
        public string AuditType { get; set; }
        public string Tabla { get; set; }
        public string PK { get; set; }
        public string Columnna { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }
        public System.DateTime Fecha { get; set; }
        public int UsuarioID { get; set; }
    }
}
