// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 07

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class DTOProductos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price {  get; set; }
        public byte Iva {  get; set; }
        public string Tienda { get; set; }
        public DTOProductos() { }

    }
}
