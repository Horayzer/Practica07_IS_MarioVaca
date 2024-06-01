// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 07


namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int idProducto { get; set; }
        public string name { get; set; }
        public decimal pvp { get; set; }
        public string impuesto { get; set; }
        public bool estado { get; set; }
        public string marca { get; set; }
    }
}
