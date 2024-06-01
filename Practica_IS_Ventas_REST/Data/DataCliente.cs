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
    public class DataCliente : IData<Clientes>
    {
        ventasEntities contexto;
        public DataCliente()
        {
            contexto = new ventasEntities();
        }

        public bool Actualizar(Clientes item)
        {
            if (contexto.Clientes.Any(p => p.id == item.id))
            {
                contexto.Entry(item).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Clientes ByID(int id)
        {
            return contexto.Clientes.FirstOrDefault(p => p.id == id);
        }

        public bool Eliminar(Clientes item)
        {
            var cliente = contexto.Clientes.FirstOrDefault(p => p.id == item.id);
            if (cliente != null)
            {
                contexto.Clientes.Remove(cliente);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Insertar(Clientes item)
        {
            if (contexto.Clientes.Add(item) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Clientes> Listar()
        {
            return contexto.Clientes.ToList();
        }
    }
}
