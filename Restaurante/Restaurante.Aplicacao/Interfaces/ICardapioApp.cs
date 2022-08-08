using Restaurante.Aplicacao.DTO.CardapioDTO;
using System.Collections.Generic;

namespace Restaurante.Aplicacao.Interfaces
{
    public interface ICardapioApp
    {
        int Incluir(CreateCardapioDTO entidade);
        void Excluir(int id);
        void Alterar(AlterCardapioDTO entidade);
        ReadCardapioDTO SelecionarPorId(int id);
        IEnumerable<ReadCardapioDTO> SelecionarTodos();
    }
}
