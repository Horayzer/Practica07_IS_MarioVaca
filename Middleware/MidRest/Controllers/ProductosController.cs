// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 07

using Logica;
using System.Web.Http;

namespace MidRest.Controllers
{
    public class ProductosController : ApiController
    {
        MiddlewareProductos logic = new MiddlewareProductos();
        // GET: Productos
        public IHttpActionResult Get()
        {
            var respuesta = logic.ListaProductosREST();
            return Ok(respuesta);
        }
    }
}
