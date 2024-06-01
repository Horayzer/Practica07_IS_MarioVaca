// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 05

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        public int id { get; set; }
        public int idFactura { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
    
        public virtual Facturas Facturas { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
