// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 07

using DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class DataProducto : IData<Productos>
    {
        ventasEntities contexto;
        public DataProducto()
        {
            contexto = new ventasEntities();
        }

        public bool Actualizar(Productos item)
        {
            // Verificar si el producto existe en la base de datos antes de actualizar
            if (contexto.Productos.Any(p => p.id == item.id))
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Productos ByID(int id)
        {
            return contexto.Productos.FirstOrDefault(p => p.id == id);
        }

        public bool Eliminar(Productos item)
        {
            // Verificar si el producto existe en la base de datos antes de eliminar
            var producto = contexto.Productos.FirstOrDefault(p => p.id == item.id);
            if (producto != null)
            {
                contexto.Productos.Remove(producto);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Insertar(Productos item)
        {
            if (contexto.Productos.Add(item) != null){
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Productos> Listar()
        {
            return contexto.Productos.ToList();
        }
    }
}
