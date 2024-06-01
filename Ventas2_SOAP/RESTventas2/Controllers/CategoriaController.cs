using AccesoDatos;
using Negocio;
using System.Web.Http;
using System.Web.Mvc;

namespace RESTventas2.Controllers
{
    public class CategoriaController : ApiController
    {
        NegocioCategoria logicCat = new NegocioCategoria();

        //Get
        public IHttpActionResult Get()
        {
            var respuesta = logicCat.ListarCategorias();
            return Ok(respuesta);
        }

        //Get/id
        public IHttpActionResult Get(int id)
        {
            Categoria respuesta = logicCat.ListarByID(id);
            if (respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }

        // POST
        public IHttpActionResult Post([FromBody] Categoria pro)
        {
            if (logicCat.AñadirCategoria(pro))
            {
                return CreatedAtRoute("DefaultApi", new { id = pro.idCategoria }, pro);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT/id
        public IHttpActionResult Put(int id, [FromBody] Categoria proActualizado)
        {
            proActualizado.idCategoria = id;
            if (logicCat.ActualizarCategoria(proActualizado))
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
            Categoria proEliminar = logicCat.ListarByID(id);
            if (proEliminar != null)
            {
                if (logicCat.EliminarCategoria(proEliminar))
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
