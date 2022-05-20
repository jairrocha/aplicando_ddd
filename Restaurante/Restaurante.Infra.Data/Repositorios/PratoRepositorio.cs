using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Infra.Data.Contextos;
using System.Collections.Generic;
using System.Linq;

namespace Restaurante.Infra.Data.Repositorios
{
    public class PratoRepositorio: RepositorioBase<Prato>, IPratoRepositorio
    {
        public PratoRepositorio(Contexto contexto) : base(contexto){}

        public IEnumerable<Prato> SelecionarPorNome(string nome)
        {
           
            return _contexto.Set<Prato>()
                .Where(_ => _.Nome.Contains(nome)).ToList();
        }
    }
}
