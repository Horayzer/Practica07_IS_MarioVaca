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
    public class LogicCliente
    {
        DataCliente data;

        public LogicCliente() 
        {
            data = new DataCliente();
        }

        public List<Clientes> ListarClientes()
        {
            List<Clientes> list = data.Listar();
            return list;
        }

        public Clientes ListarByID(int id)
        {
            Clientes cli = data.ByID(id);
            return cli;
        }

        public bool AñadirCliente(Clientes cli)
        {
            return data.Insertar(cli);
        }

        public bool ActualizarCliente(Clientes cli)
        {
            return data.Actualizar(cli);
        }

        public bool EliminarCliente(Clientes cli)
        {
            return data.Eliminar(cli);
        }
    }
}
