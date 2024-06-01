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
    public class DataCategoria : IData<Categorias>
    {
        ventasEntities contexto;

        public DataCategoria()
        {
            contexto = new ventasEntities();
        }

        public bool Actualizar(Categorias item)
        {
            if (contexto.Categorias.Any(p => p.id == item.id))
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Categorias ByID(int id)
        {
            return contexto.Categorias.FirstOrDefault(p => p.id == id);
        }

        public bool Eliminar(Categorias item)
        {
            var cat = contexto.Categorias.FirstOrDefault(p => p.id == item.id);
            if (cat != null)
            {
                contexto.Categorias.Remove(cat);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Insertar(Categorias categoria)
        {
            if (contexto.Categorias.Add(categoria) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Categorias> Listar()
        {
            return contexto.Categorias.ToList();
        }
    }
}