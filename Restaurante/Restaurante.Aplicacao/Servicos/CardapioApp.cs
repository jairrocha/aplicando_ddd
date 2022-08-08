using AutoMapper;
using Restaurante.Aplicacao.DTO.CardapioDTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace Restaurante.Aplicacao.Servicos
{
    public class CardapioApp : ICardapioApp
    {
        private readonly IServicoBase<Cardapio> _servico;
        private readonly IMapper _iMapper;

        public CardapioApp(IServicoBase<Cardapio> servico, IMapper iMapper) 
        {
            _servico = servico;
            _iMapper = iMapper;
        }

        public void Alterar(AlterCardapioDTO entidade)
        {
            _servico.Alterar(_iMapper.Map<Cardapio>(entidade));
        }

        public void Excluir(int id)
        {
            _servico.Excluir(id);
        }

        public int Incluir(CreateCardapioDTO entidade)
        {
           return _servico.Incluir(_iMapper.Map<Cardapio>(entidade));
        }

        public ReadCardapioDTO SelecionarPorId(int id)
        {
            return _iMapper.Map<ReadCardapioDTO>(_servico.SelecionarPorId(id));
        }

        public IEnumerable<ReadCardapioDTO> SelecionarTodos()
        {
            return _iMapper.Map<IEnumerable<ReadCardapioDTO>>(_servico.SelecionarTodos());
        }
    }
}
