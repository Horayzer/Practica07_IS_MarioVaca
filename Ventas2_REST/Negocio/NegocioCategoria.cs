using AccesoDatos;
using System;
using System.Collections.Generic;
using Datos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioCategoria
    {
        DatosCategoria data;

        public NegocioCategoria()
        {
            data = new DatosCategoria();
        }

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> list = data.Listar();
            return list;
        }

        public Categoria ListarByID(int id)
        {
            Categoria cat = data.ByID(id);
            return cat;
        }

        public bool AñadirCategoria(Categoria cat)
        {
            return data.Insertar(cat);
        }

        public bool ActualizarCategoria(Categoria cat)
        {
            return data.Actualizar(cat);
        }

        public bool EliminarCategoria(Categoria cat)
        {
            return data.Eliminar(cat);
        }
    }
}
