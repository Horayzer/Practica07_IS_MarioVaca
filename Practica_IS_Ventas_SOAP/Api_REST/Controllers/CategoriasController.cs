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
    public class CategoriasController : ApiController
    {
        LogicCategoria logic = new LogicCategoria();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = logic.ListarProductos();
            return Ok(respuesta);
        }

        //Get/id
        public IHttpActionResult Get(int id)
        {
            Categorias respuesta = logic.ListarByID(id);
            if (respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }

        // POST
        public IHttpActionResult Post([FromBody] Categorias item)
        {
            if (logic.AñadirCategoria(item))
            {
                return CreatedAtRoute("DefaultApi", new { id = item.id }, item);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT/id
        public IHttpActionResult Put(int id, [FromBody] Categorias item)
        {
            item.id = id;
            if (logic.ActualizarCategoria(item))
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
            Categorias item = logic.ListarByID(id);
            if (item != null)
            {
                if (logic.EliminarCategoria(item))
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