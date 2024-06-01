// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 05

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ventasEntities : DbContext
    {
        public ventasEntities()
            : base("name=ventasEntities")
        {
            Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFactura { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
    
        public virtual ObjectResult<ObtenerDetalleFactura_Result> ObtenerDetalleFactura(Nullable<int> idFactura)
        {
            var idFacturaParameter = idFactura.HasValue ?
                new ObjectParameter("idFactura", idFactura) :
                new ObjectParameter("idFactura", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerDetalleFactura_Result>("ObtenerDetalleFactura", idFacturaParameter);
        }
    }
}
