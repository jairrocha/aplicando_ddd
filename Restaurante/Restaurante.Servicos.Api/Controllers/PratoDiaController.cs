
using Microsoft.AspNetCore.Mvc;
using Restaurante.Aplicacao.DTO.PratoDia;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Infra.Data.Exceptions;
using System;
using System.Linq;

namespace Restaurante.Servicos.Api.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class PratoDiaController : Controller
    {

        private readonly IPratoDiaApp _app;

        #region [Construtor]
        public PratoDiaController(IPratoDiaApp app)
        {
            _app = app;
        }
        #endregion


        [HttpGet]
        //[Route("")]
        public IActionResult Listar([FromQuery] int diaDaSemana)
        {

            try
            {
                var result = _app.SelecionarTodos();


                if (diaDaSemana > 0 && result != null)
                {
                    result = _app.SelecionarTodos().Where(_ => _.Cardapio.CodDia.Equals(diaDaSemana)).ToList();

                    if (result.Count() == 0) { return NotFound(); }

                }

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {

                var result = _app.SelecionarPorId(id);

                if (result == null)
                {
                    return NotFound();
                }

                return new OkObjectResult(_app.SelecionarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] CreatePratoDiaDTO dado)
        {
            try
            {
                int id = _app.Incluir(dado);
                return CreatedAtAction(nameof(Incluir), new { Id = id }, dado);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] AlterPratoDiaDTO dado)
        {
            try
            {

                _app.Alterar(dado);
                return new NoContentResult();

            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                _app.Excluir(id);
                return new NoContentResult();
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}
