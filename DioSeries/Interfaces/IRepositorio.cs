using System.Collections.Generic;

namespace DioSeries.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornarPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualizar(int id, T entidade);
         void ProximoId();

    }
}