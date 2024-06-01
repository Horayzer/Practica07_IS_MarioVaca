// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 07

using Datos.DTO;
using Logica;
using System.Collections.Generic;
using System.Web.Services;

namespace MidSoap
{
    /// <summary>
    /// Descripción breve de UWSProductosSOAP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // [System.Web.Script.Services.ScriptService]
    public class UWSProductosSOAP : System.Web.Services.WebService
    {
        MiddlewareProductos mdSOAP = new MiddlewareProductos();

        [WebMethod]
        public List<DTOProductos> AllProductos()
        {
            return mdSOAP.ListaProductosSOAP();
        }
    }
}
