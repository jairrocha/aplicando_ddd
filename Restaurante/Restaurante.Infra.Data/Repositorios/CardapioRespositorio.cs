using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Infra.Data.Contextos;

namespace Restaurante.Infra.Data.Repositorios
{
    public class CardapioRespositorio : RepositorioBase<Cardapio>, ICardapioRepositorio
    {
        public CardapioRespositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
