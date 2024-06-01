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
    public class DataDetalleFactura : IData<DetalleFactura>
    {
        ventasEntities contexto;
        public DataDetalleFactura()
        {
            contexto = new ventasEntities();
        }

        public bool Actualizar(DetalleFactura item)
        {
            if (contexto.DetalleFactura.Any(p => p.id == item.id))
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public DetalleFactura ByID(int id)
        {
            return contexto.DetalleFactura.FirstOrDefault(p => p.id == id);
        }

        public bool Eliminar(DetalleFactura item)
        {
            var detFactura = contexto.DetalleFactura.FirstOrDefault(p => p.id == item.id);
            if (detFactura != null)
            {
                contexto.DetalleFactura.Remove(detFactura);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Insertar(DetalleFactura item)
        {
            if (contexto.DetalleFactura.Add(item) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<DetalleFactura> Listar()
        {
            return contexto.DetalleFactura.ToList();
        }
    }
}
