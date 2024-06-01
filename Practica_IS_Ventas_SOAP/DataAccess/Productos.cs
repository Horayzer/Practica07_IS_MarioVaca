// NOMBRE APELLIDOS: MARIO ANDR�S VACA MORA
// PARALELO: 3228
// SI � INTEGRACI�N DE SISTEMAS 
// FECHA: 28/04/2024
// PR�CTICA No. # 07

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.DetalleFactura = new List<DetalleFactura>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio_unitario { get; set; }
        public byte iva { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore] //Para las clases que tienen relaci�n, para las relaciones
        public virtual List<DetalleFactura> DetalleFactura { get; set; }
    }
}

