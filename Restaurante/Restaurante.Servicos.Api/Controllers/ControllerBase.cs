using Microsoft.AspNetCore.Mvc;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Infra.Data.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Restaurante.Servicos.Api.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerBase<Entidade, EntidadeDTO> : Controller
        where Entidade : EntidadeBase
        where EntidadeDTO : DTOBase
    {

        private readonly IAppBase<Entidade, EntidadeDTO> _app;

        public ControllerBase(IAppBase<Entidade, EntidadeDTO> app)
        {
            _app = app;
        }

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
        public IActionResult Incluir([FromBody] EntidadeDTO dado)
        {
            try
            {
                int id = _app.Incluir(dado);
                return CreatedAtAction(nameof(Incluir), new { Id = id }, dado);

                /*
                 * Utilize na controller o atributo: [ApiController] evitar o If abaixo.
                 * ref.:https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.2#annotation-with-apicontroller-attribute
                 * 
                if (ModelState.IsValid)
                    return CreatedAtAction(nameof(Incluir), new { Id = id }, dado);
                else
                    return BadRequest(ModelState);
                */

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] EntidadeDTO dado)
        {
            try
            {
                
                _app.Alterar(dado);
                return new NoContentResult();
                
            }
            catch(EntityNotFoundException)
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

        [HttpDelete]
        public IActionResult Excluir([FromBody] EntidadeDTO dado)
        {
            try
            {
                _app.Excluir(dado);
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
