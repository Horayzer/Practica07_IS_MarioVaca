// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 28/04/2024
// PRÁCTICA No. # 05

using System.Collections.Generic;


namespace Data
{
    public interface IData<T>
    {
        List<T> Listar();
        T ByID(int id);
        bool Insertar(T item);
        bool Actualizar(T item);
        bool Eliminar(T item);
    }
}
