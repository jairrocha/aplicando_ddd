using Microsoft.AspNetCore.Mvc;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using System;
using System.Linq;

namespace Restaurante.Servicos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PratoController : ControllerBase<Prato, PratoDTO>
    {

        private readonly IPratoApp _app;

        public PratoController(IPratoApp app)
            : base(app)
        {
            _app = app;
        }

        [HttpGet]
        [Route("Nome")]
        public IActionResult SelecionarPorNome([FromBody] string nome)
        {

            try
            {
                var result = _app.SelecionarPorNome(nome);

                if (result.Count() == 0)
                {
                    return NotFound();
                }

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }


    }
}
