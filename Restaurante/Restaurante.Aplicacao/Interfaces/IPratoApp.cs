using Restaurante.Aplicacao.DTO;
using Restaurante.Dominio.Entidades;
using System.Collections.Generic;

namespace Restaurante.Aplicacao.Interfaces
{
    public interface IPratoApp : IAppBase<Prato, PratoDTO>
    {
        IEnumerable<PratoDTO> SelecionarPorNome(string nome);
    }
}
