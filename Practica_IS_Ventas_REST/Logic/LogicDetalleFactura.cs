// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 05

using Data;
using DataAccess;
using System.Collections.Generic;

namespace Logic
{
    public class LogicDetalleFactura
    {
        DataDetalleFactura data;

        public LogicDetalleFactura()
        {
            data = new DataDetalleFactura();
        }

        public List<DetalleFactura> ListarDetalleFactura()
        {
            List<DetalleFactura> list = data.Listar();
            return list;
        }

        public DetalleFactura ListarByID(int id)
        {
            DetalleFactura deFac = data.ByID(id);
            return deFac;
        }

        public bool AñadirDetalleFactura(DetalleFactura deFac)
        {
            return data.Insertar(deFac);
        }

        public bool ActualizarDetalleFactura(DetalleFactura deFac)
        {
            return data.Actualizar(deFac);
        }

        public bool EliminarDetalleFactura(DetalleFactura deFac)
        {
            return data.Eliminar(deFac);
        }
    }
}
