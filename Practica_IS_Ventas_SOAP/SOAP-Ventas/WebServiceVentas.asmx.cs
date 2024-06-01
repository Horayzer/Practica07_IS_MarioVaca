// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 07

using DataAccess;
using Logic;
using System.Collections.Generic;
using System.Web.Services;

namespace SOAP_Ventas
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebServiceVentas : System.Web.Services.WebService
    {
        private LogicProducto producto = new LogicProducto();

        [WebMethod]
        public List<Productos> ListarProductos()
        {
            return producto.ListarProductos();
        }

        [WebMethod]
        public Productos BuscarxID(int id)
        {
            Productos temp = producto.ListarByID(id);
            if(temp != null)
            {
                return temp;
            }
            return null;
        }

        [WebMethod]
        public bool Eliminar(Productos item)
        {
            return producto.EliminarProducto(item);
        }

        [WebMethod]
        public bool Añadir(Productos item)
        {
            return producto.AñadirProducto(item);
        }

        [WebMethod]
        public bool Actualizar(Productos item)
        {
            return producto.ActualizarProducto(item);
        }
    }
}
