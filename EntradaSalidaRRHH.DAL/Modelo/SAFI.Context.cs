﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SAFIEntities : DbContext
    {
        public SAFIEntities()
            : base("name=SAFIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<DocumentosPendientesCobroP2P> ReporteDocumentosPendientesCobroP2P(Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<int> codigoServicio)
        {
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            var codigoServicioParameter = codigoServicio.HasValue ?
                new ObjectParameter("CodigoServicio", codigoServicio) :
                new ObjectParameter("CodigoServicio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DocumentosPendientesCobroP2P>("ReporteDocumentosPendientesCobroP2P", fechaInicioParameter, fechaFinParameter, codigoServicioParameter);
        }
    }
}