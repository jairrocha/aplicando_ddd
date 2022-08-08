using Microsoft.AspNetCore.Mvc;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.DTO.CardapioDTO;
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
    public class CardapioController : Controller
    {
        private readonly ICardapioApp _app;

        #region [Construtor]
        public CardapioController(ICardapioApp app)
        {
            _app = app;
        }
        #endregion


        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {

            try
            {
                var result = _app.SelecionarTodos();
                             
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
        public IActionResult Incluir([FromBody] CreateCardapioDTO dado)
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
        public IActionResult Alterar([FromBody] AlterCardapioDTO dado)
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
