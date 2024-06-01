// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 05

using Data;
using DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class LogicStoreProcedure
    {
        DataStoreProcedure data;

        public LogicStoreProcedure()
        {
            data = new Data.DataStoreProcedure();
        }

        public List<ObtenerDetalleFactura_Result> StoreProcedure(int id)
        {
            return data.StoreProcedure(id).ToList();
        }
    }
}
