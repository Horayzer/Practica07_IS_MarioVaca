// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 07

using Newtonsoft.Json.Linq;
using System;

namespace Datos.Entidades
{
    public class ProductosSuperX
    {
        public int id { get; set; }
        public string name { get; set; }
        public double pvp { get; set; }
        public byte impuesto { get; set; }
        public bool estado { get; set; }
        public string marca { get; set; }
        public ProductosSuperX() { }
        public ProductosSuperX(string datoJson) 
        {
            JObject data = JObject.Parse(datoJson);
            id = (int)data["id"];
            name = (string)data["name"];
            pvp = (double)data["pvp"];
            impuesto = (byte)data["impuesto"];
            estado = (bool)data["estado"];
            marca = (string)data["marca"];
        }
    }
}
