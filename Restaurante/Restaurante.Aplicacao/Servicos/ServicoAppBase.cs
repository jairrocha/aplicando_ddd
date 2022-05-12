using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Aplicacao.Servicos
{
    public class  ServicoAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade: EntidadeBase
        where TEntidadeDTO : DTOBase
    {
        protected readonly IServicoBase<TEntidade> servico;
        protected readonly IMapper iMapper;

        public ServicoAppBase(IServicoBase<TEntidade> servico, IMapper iMapper)
        {
            this.servico = servico;
            this.iMapper = iMapper;
        }

        public int Incluir(TEntidadeDTO entidade)
        {
            return servico.Incluir(iMapper.Map<TEntidade>(entidade));
        }

        public void Excluir(int Id)
        {
            servico.Excluir(Id);
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            servico.Excluir(iMapper.Map<TEntidade>(entidade));
        }

        public void Alterar(TEntidadeDTO entidade)
        {
            servico.Alterar(iMapper.Map<TEntidade>(entidade));
        }

        public TEntidadeDTO SelecionarPorId(int Id)
        {
            return iMapper.Map<TEntidadeDTO>(servico.SelecionarPorId(Id));
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.SelecionarTodos());
        }

        
    }
}
