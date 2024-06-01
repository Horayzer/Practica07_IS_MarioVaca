using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosCategoria : IDatos<Categoria>
    {
        ventasBDEntities contexto;

        public DatosCategoria()
        {
            contexto = new ventasBDEntities();
        }

        public bool Actualizar(Categoria item)
        {
            if (contexto.Categoria.Any(p => p.idCategoria == item.idCategoria))
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Categoria ByID(int id)
        {
            return contexto.Categoria.FirstOrDefault(p => p.idCategoria == id);
        }

        public bool Eliminar(Categoria item)
        {
            var cat = contexto.Categoria.FirstOrDefault(p => p.idCategoria == item.idCategoria);
            if (cat != null)
            {
                contexto.Categoria.Remove(cat);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Insertar(Categoria categoria)
        {
            if (contexto.Categoria.Add(categoria) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Categoria> Listar()
        {
            return contexto.Categoria.ToList();
        }
    }
}
