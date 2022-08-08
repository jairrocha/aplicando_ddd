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
    public class  AppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade: EntidadeBase
        where TEntidadeDTO : DTOBase
    {
        private readonly IServicoBase<TEntidade> _servico;
        protected readonly IMapper _iMapper;

        public AppBase(IServicoBase<TEntidade> servico, IMapper iMapper)
        {
            _servico = servico;
            _iMapper = iMapper;
        }

        public int Incluir(TEntidadeDTO entidade)
        {
            return _servico.Incluir(_iMapper.Map<TEntidade>(entidade));
        }

        public void Excluir(int Id)
        {
            _servico.Excluir(Id);
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            _servico.Excluir(_iMapper.Map<TEntidade>(entidade));
        }

        public void Alterar(TEntidadeDTO entidade)
        {
            _servico.Alterar(_iMapper.Map<TEntidade>(entidade));
        }

        public TEntidadeDTO SelecionarPorId(int Id)
        {
            return _iMapper.Map<TEntidadeDTO>(_servico.SelecionarPorId(Id));
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            return _iMapper.Map<IEnumerable<TEntidadeDTO>>(_servico.SelecionarTodos());
        }

        
    }
}
