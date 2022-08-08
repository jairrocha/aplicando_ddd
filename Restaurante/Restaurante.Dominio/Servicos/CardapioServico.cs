using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;

namespace Restaurante.Dominio.Servicos
{
    public class CardapioServico : ServicoBase<Cardapio>, ICardapioServico
    {
        public CardapioServico(IRepositorioBase<Cardapio> repositorio) 
            : base(repositorio)
        {
        }
    }
}
