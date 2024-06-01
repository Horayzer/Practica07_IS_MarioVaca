// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 07

using AccesoDatos;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DatosProducto : IDatos<Producto>
    {
        ventasBDEntities contexto;
        public DatosProducto()
        {
            contexto = new ventasBDEntities();
        }

        public bool Actualizar(Producto item)
        {
            // Verificar si el producto existe en la base de datos antes de actualizar
            if (contexto.Producto.Any(p => p.idProducto == item.idProducto))
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Producto ByID(int id)
        {
            return contexto.Producto.FirstOrDefault(p => p.idProducto == id);
        }

        public bool Eliminar(Producto item)
        {
            // Verificar si el producto existe en la base de datos antes de eliminar
            var producto = contexto.Producto.FirstOrDefault(p => p.idProducto == item.idProducto);
            if (producto != null)
            {
                contexto.Producto.Remove(producto);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Insertar(Producto item)
        {
            if (contexto.Producto.Add(item) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Producto> Listar()
        {
            return contexto.Producto.ToList();
        }

    }
}
