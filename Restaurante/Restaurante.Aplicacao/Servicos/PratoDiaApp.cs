using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.DTO.PratoDia;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace Restaurante.Aplicacao.Servicos
{
    public class PratoDiaApp : IPratoDiaApp
    {
        private readonly IServicoBase<PratoDia> _servico;
        private readonly IMapper _iMapper;

        public PratoDiaApp(IServicoBase<PratoDia> servico, IMapper iMapper)
        {
            _servico = servico;
            _iMapper = iMapper;
        }

        public void Alterar(AlterPratoDiaDTO entidade)
        {
            _servico.Alterar(_iMapper.Map<PratoDia>(entidade));
        }

        public void Excluir(int id)
        {
            _servico.Excluir(id);
        }

        public int Incluir(CreatePratoDiaDTO entidade)
        {
            return _servico.Incluir(_iMapper.Map<PratoDia>(entidade));
        }

        public ReadPratoDiaDTO SelecionarPorId(int id)
        {
            return _iMapper.Map<ReadPratoDiaDTO>(_servico.SelecionarPorId(id));
        }

        public IEnumerable<ReadPratoDiaDTO> SelecionarTodos()
        {
            return _iMapper.Map<IEnumerable<ReadPratoDiaDTO>>(_servico.SelecionarTodos());
        }
    }
}


