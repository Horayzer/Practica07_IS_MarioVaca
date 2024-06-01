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
    public class ProductosController : ApiController
    {
        LogicProducto logicPro = new LogicProducto();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = logicPro.ListarProductos();
            return Ok(respuesta);
        }

        //Get/id
        public IHttpActionResult Get(int id)
        {
            Productos respuesta = logicPro.ListarByID(id);
            if(respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }

        // POST
        public IHttpActionResult Post([FromBody] Productos pro)
        {
            if (logicPro.AñadirProducto(pro))
            {
                return CreatedAtRoute("DefaultApi", new { id = pro.id }, pro);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT/id
        public IHttpActionResult Put(int id, [FromBody] Productos proActualizado)
        {
            proActualizado.id = id;
            if (logicPro.ActualizarProducto(proActualizado))
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
            Productos proEliminar = logicPro.ListarByID(id);
            if (proEliminar != null)
            {
                if (logicPro.EliminarProducto(proEliminar))
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