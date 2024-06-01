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
    public class LogicFactura
    {
        DataFactura data;

        public LogicFactura()
        {
            data = new DataFactura();
        }

        public List<Facturas> ListarFacturas()
        {
            List<Facturas> list = data.Listar();
            return list;
        }

        public Facturas ListarByID(int id)
        {
            Facturas fac = data.ByID(id);
            return fac;
        }

        public bool AñadirFactura(Facturas fac)
        {
            return data.Insertar(fac);
        }

        public bool ActualizarFactura(Facturas fac)
        {
            return data.Actualizar(fac);
        }

        public bool EliminarFactura(Facturas fac)
        {
            return data.Eliminar(fac);
        }
    }
}
