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
    public class PratoApp : ServicoAppBase<Prato, PratoDTO>, IPratoApp
    {

        private readonly IPratoServico _servico;

        public PratoApp(IMapper iMaper, IPratoServico servico)
            :base(servico, iMaper)
        {
            _servico = servico;
        }

        public IEnumerable<PratoDTO> SelecionarPorNome(string nome)
        {
            return _iMapper.Map<IEnumerable<PratoDTO>>( _servico.SelecionarPorNome(nome));
        }
    }
}
