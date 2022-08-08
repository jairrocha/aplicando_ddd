using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Infra.Data.Contextos;

namespace Restaurante.Infra.Data.Repositorios
{
    public class PratoDiaRepositorio : RepositorioBase<PratoDia>, IPratoDiaRepositorio
    {
        public PratoDiaRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
