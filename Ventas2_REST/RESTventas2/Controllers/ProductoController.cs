using AccesoDatos;
using Negocio;
using System.Web.Http;

namespace RESTventas2.Controllers
{
    public class ProductoController : ApiController
    {
        NegocioProducto logicPro = new NegocioProducto();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = logicPro.ListarProductos();
            return Ok(respuesta);
        }

        //Get/id
        public IHttpActionResult Get(int id)
        {
            Producto respuesta = logicPro.ListarByID(id);
            if (respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }

        // POST
        public IHttpActionResult Post([FromBody] Producto pro)
        {
            if (logicPro.AñadirProducto(pro))
            {
                return CreatedAtRoute("DefaultApi", new { id = pro.idProducto }, pro);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT/id
        public IHttpActionResult Put(int id, [FromBody] Producto proActualizado)
        {
            proActualizado.idProducto = id;
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
            Producto proEliminar = logicPro.ListarByID(id);
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
