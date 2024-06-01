using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioProducto
    {
        DatosProducto data;

        public NegocioProducto()
        {
            data = new DatosProducto();
        }

        public List<Producto> ListarProductos()
        {
            return data.Listar();
        }

        public Producto ListarByID(int id)
        {
            Producto pro = data.ByID(id);
            return pro;
        }

        public bool AñadirProducto(Producto pro)
        {
            return data.Insertar(pro);
        }

        public bool ActualizarProducto(Producto pro)
        {
            return data.Actualizar(pro);
        }

        public bool EliminarProducto(Producto pro)
        {
            return data.Eliminar(pro);
        }
    }
}
