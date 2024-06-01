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
    public class DataFactura : IData<Facturas>
    {
        ventasEntities contexto;
        public DataFactura()
        {
            contexto = new ventasEntities();
        }

        public bool Actualizar(Facturas item)
        {
            if (contexto.Facturas.Any(p => p.numero == item.numero))
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Facturas ByID(int id)
        {
            return contexto.Facturas.FirstOrDefault(p => p.numero == id);
        }

        public bool Eliminar(Facturas item)
        {
            var factura = contexto.Facturas.FirstOrDefault(p => p.numero == item.numero);
            if (factura != null)
            {
                contexto.Facturas.Remove(factura);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Insertar(Facturas item)
        {
            if (contexto.Facturas.Add(item) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Facturas> Listar()
        {
            return contexto.Facturas.ToList();
        }
    }
}
