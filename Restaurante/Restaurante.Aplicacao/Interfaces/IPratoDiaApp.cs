using Restaurante.Aplicacao.DTO.PratoDia;
using System.Collections.Generic;

namespace Restaurante.Aplicacao.Interfaces
{
    public interface IPratoDiaApp

    {
        int Incluir(CreatePratoDiaDTO entidade);
        void Excluir(int id);
        void Alterar(AlterPratoDiaDTO entidade);
        ReadPratoDiaDTO SelecionarPorId(int id);
        IEnumerable<ReadPratoDiaDTO> SelecionarTodos();
    }
}
