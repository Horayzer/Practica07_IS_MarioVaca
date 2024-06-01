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
    public class LogicCategoria
    {
        DataCategoria data;

        public LogicCategoria()
        {
            data = new DataCategoria();
        }

        public List<Categorias> ListarProductos()
        {
            List<Categorias> list = data.Listar();
            return list;
        }

        public Categorias ListarByID(int id)
        {
            Categorias cat = data.ByID(id);
            return cat;
        }

        public bool AñadirCategoria(Categorias cat)
        {
            return data.Insertar(cat);
        }

        public bool ActualizarCategoria(Categorias cat)
        {
            return data.Actualizar(cat);
        }

        public bool EliminarCategoria(Categorias cat)
        {
            return data.Eliminar(cat);
        }
    }
}
