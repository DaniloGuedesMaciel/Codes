using System.Collections.Generic;

namespace DIO.Series.Serviços
{
    public interface Registro<T>
    {
        List<T> listar();
        T Retornar(int id);
        void Inserir(T entidade);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}