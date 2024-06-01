// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 07

using AccesoDatos;
using Negocio;
using System.Collections.Generic;
using System.Web.Services;

namespace SOAPventas2
{
    /// <summary>
    /// Descripción breve de ServiceSoapVentas2Producto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceSoapVentas2Producto : System.Web.Services.WebService
    {
        private NegocioProducto producto = new NegocioProducto();

        [WebMethod]
        public List<Producto> ListarProductos()
        {
            return producto.ListarProductos();
        }

        [WebMethod]
        public Producto BuscarxID(int id)
        {
            Producto temp = producto.ListarByID(id);
            if (temp != null)
            {
                return temp;
            }
            return null;
        }

        [WebMethod]
        public bool Eliminar(Producto item)
        {
            return producto.EliminarProducto(item);
        }

        [WebMethod]
        public bool Añadir(Producto item)
        {
            return producto.AñadirProducto(item);
        }

        [WebMethod]
        public bool Actualizar(Producto item)
        {
            return producto.ActualizarProducto(item);
        }
    }
}
