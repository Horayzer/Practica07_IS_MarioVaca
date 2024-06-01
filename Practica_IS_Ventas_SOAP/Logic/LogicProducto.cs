// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 07

using Data;
using DataAccess;
using System.Collections.Generic;

namespace Logic
{
    public class LogicProducto
    {
        DataProducto data;

        public LogicProducto() {
            data = new DataProducto();
        }

        public List<Productos> ListarProductos()
        {
            return data.Listar();
        }

        public Productos ListarByID(int id)
        {
            Productos pro = data.ByID(id);
            return pro;
        }

        public bool AñadirProducto(Productos pro) {
            return data.Insertar(pro);
        }

        public bool ActualizarProducto(Productos pro)
        {
            return data.Actualizar(pro);
        }

        public bool EliminarProducto(Productos pro)
        {
            return data.Eliminar(pro);
        }
    }
}
