// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 07

using Newtonsoft.Json.Linq;

namespace Datos.Entidades
{
    public class ProductosTiendaMil
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio_unitario { get; set; }
        public byte iva { get; set; }
        public ProductosTiendaMil() { }
        public ProductosTiendaMil(string datoJson)
        {
            JObject data = JObject.Parse(datoJson);
            id = (int)data["id"];
            nombre = (string)data["nombre"];
            precio_unitario = (double)data["precio_unitario"];
            iva = (byte)data["iva"];
        }
    }
}
