using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;

namespace Restaurante.Dominio.Servicos
{
    public class PratoDiaServico : ServicoBase<PratoDia>, IPratoDiaServico
    {

        public PratoDiaServico(IRepositorioBase<PratoDia> repositorio) 
            :base(repositorio)
        {
        }


    }
}
