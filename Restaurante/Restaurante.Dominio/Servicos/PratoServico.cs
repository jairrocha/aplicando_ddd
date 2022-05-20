using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio.Servicos
{
    public class PratoServico : ServicoBase<Prato>, IPratoServico
    {
        private readonly IPratoRepositorio _repositorio;

        public PratoServico(IPratoRepositorio repositorio): base(repositorio)
        {
           _repositorio = repositorio;
        }

        public IEnumerable<Prato> SelecionarPorNome(string nome)
        {
            return _repositorio.SelecionarPorNome(nome);
        }
    }
}
