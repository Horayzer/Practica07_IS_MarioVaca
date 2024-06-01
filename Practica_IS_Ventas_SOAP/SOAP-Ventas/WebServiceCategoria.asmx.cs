using DataAccess;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAP_Ventas
{
    /// <summary>
    /// Descripción breve de WebServiceCategoria
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCategoria : System.Web.Services.WebService
    {
        private LogicCategoria logic = new LogicCategoria();

        [WebMethod]
        public List<Categorias> ListarProductos()
        {
            return logic.ListarProductos();
        }

        [WebMethod]
        public Categorias BuscarxID(int id)
        {
            Categorias temp = logic.ListarByID(id);
            if (temp != null)
            {
                return temp;
            }
            return null;
        }

        public bool Eliminar(Categorias item)
        {
            return logic.EliminarCategoria(item);
        }

        public bool Añadir(Categorias item)
        {
            return logic.AñadirCategoria(item);
        }

        public bool Actualizar(Categorias item)
        {
            return logic.ActualizarCategoria(item);
        }
    }
}
