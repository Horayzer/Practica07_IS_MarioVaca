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
    public class ClientesController : ApiController
    {
        LogicCliente logic = new LogicCliente();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = logic.ListarClientes();
            return Ok(respuesta);
        }

        //Get/id
        public IHttpActionResult Get(int id)
        {
            Clientes respuesta = logic.ListarByID(id);
            if (respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }

        // POST
        public IHttpActionResult Post([FromBody] Clientes item)
        {
            if (logic.AñadirCliente(item))
            {
                return CreatedAtRoute("DefaultApi", new { id = item.id }, item);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT/id
        public IHttpActionResult Put(int id, [FromBody] Clientes item)
        {
            item.id = id;
            if (logic.ActualizarCliente(item))
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
            Clientes item = logic.ListarByID(id);
            if (item != null)
            {
                if (logic.EliminarCliente(item))
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