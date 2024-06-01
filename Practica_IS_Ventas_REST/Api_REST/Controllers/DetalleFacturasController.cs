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
    public class DetalleFacturasController : ApiController
    {
        LogicDetalleFactura logic = new LogicDetalleFactura();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = logic.ListarDetalleFactura();
            return Ok(respuesta);
        }

        //Get/id
        public IHttpActionResult Get(int id)
        {
            DetalleFactura respuesta = logic.ListarByID(id);
            if (respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }

        // POST
        public IHttpActionResult Post([FromBody] DetalleFactura item)
        {
            if (logic.AñadirDetalleFactura(item))
            {
                return CreatedAtRoute("DefaultApi", new { id = item.id }, item);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT/id
        public IHttpActionResult Put(int id, [FromBody] DetalleFactura item)
        {
            item.id = id;
            if (logic.ActualizarDetalleFactura(item))
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
            DetalleFactura item = logic.ListarByID(id);
            if (item != null)
            {
                if (logic.EliminarDetalleFactura(item))
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