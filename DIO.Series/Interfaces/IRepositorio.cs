using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>

    {
        List<T> lista();

        T RetormaPorId(int id);
        void insere(T entidade);
        void exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoID();



    }
}
