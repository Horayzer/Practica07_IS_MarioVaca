// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 05

using DataAccess;
using System.Collections.Generic;
using System.Linq;


namespace Data
{
    public class DataStoreProcedure
    {
        ventasEntities contexto;
        public DataStoreProcedure()
        {
            contexto = new ventasEntities();
        }

        public List<ObtenerDetalleFactura_Result> StoreProcedure(int id)
        {
            return contexto.ObtenerDetalleFactura(id).ToList();
        }
    }
}
