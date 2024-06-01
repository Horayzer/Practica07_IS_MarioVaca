// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 05

namespace DataAccess
{
    using System;
    
    public partial class ObtenerDetalleFactura_Result
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public byte IVA { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
