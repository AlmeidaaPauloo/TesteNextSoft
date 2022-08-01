using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.src.dtos;
using TestePratico.src.service;


namespace TestePratico.src.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondominioController : ControllerBase
    {
        private readonly ICondominioService _condominioService;
        public CondominioController(ICondominioService condominioService)
        {
            _condominioService = condominioService; 
        }
        
        [HttpPost]
        public async Task Post([FromBody] NovoCondominioDTO dto)
        {
            await _condominioService.NovoCondominioAsync(dto);
        }
        
        [HttpGet]
        public async Task<ActionResult> ListarCondominiosIdAsync()
        {
            var list = await _condominioService.ListarCondominiosIdAsync();
            if (list.Count < 1) return NoContent();
            return Ok(list);
        }
        
        [HttpPut]
        public async Task<ActionResult> AtualizarCondominioAsync([FromBody] AtualizarCondominioDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _condominioService.AtualizarCondominioAsync(dto);
            return Ok(dto);
        }


        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeletarCondominioAsync([FromRoute] int idCondominio)
        {
            await _condominioService.DeletarCondominioAsync(idCondominio);
            return NoContent();
        }
    }
}
