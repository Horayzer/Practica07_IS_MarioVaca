// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 05

using DataAccess;
using Logic;
using System.Collections.Generic;
using System.Web.Http;

namespace Api_REST.Controllers
{
    public class StoreProcedureController : ApiController
    {
        LogicStoreProcedure logicStoreProcedure;
        public StoreProcedureController()
        {
            logicStoreProcedure = new LogicStoreProcedure();
        }

        // GET: api/StoreProcedures
        public IHttpActionResult Get(int id)
        {
            List<ObtenerDetalleFactura_Result> storeProcedure = logicStoreProcedure.StoreProcedure(id);
            return Ok(storeProcedure);
        }
    }
}