// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 05

using DataAccess;
using Logic;
using System.Web.Http;

namespace Api_REST.Controllers
{
    public class FacturasController : ApiController
    {
        LogicFactura logic = new LogicFactura();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = logic.ListarFacturas();
            return Ok(respuesta);
        }

        //Get/id
        public IHttpActionResult Get(int id)
        {
            Facturas respuesta = logic.ListarByID(id);
            if (respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }

        // POST
        public IHttpActionResult Post([FromBody] Facturas item)
        {
            if (logic.AñadirFactura(item))
            {
                return CreatedAtRoute("DefaultApi", new { id = item.numero }, item);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT/id
        public IHttpActionResult Put(int id, [FromBody] Facturas item)
        {
            item.numero = id;
            if (logic.ActualizarFactura(item))
            {
                return Ok();
            }
            else
            {
                return InternalServerError();
            }
        }

        // DELETE/id
        public IHttpActionResult Delete(int id)
        {
            Facturas item = logic.ListarByID(id);
            if (item != null)
            {
                if (logic.EliminarFactura(item))
                {
                    return Ok();
                }
                else
                {
                    return InternalServerError();
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}