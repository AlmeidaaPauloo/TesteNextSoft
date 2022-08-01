using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestePratico.src.dtos;
using TestePratico.src.service;
using Microsoft.EntityFrameworkCore;


namespace TestePratico.src.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliaController : ControllerBase
    {
        private readonly IFamiliaService _familiaService;
        public FamiliaController(IFamiliaService familiaService)
        {
            _familiaService = familiaService;
        }

        [HttpPost]
        public async Task Post([FromBody] NovaFamiliaDTO familia)
        {
            await _familiaService.NovaFamiliaAsync(familia);
        }

        [HttpGet]
        public async Task<ActionResult> ListarFamiliasIdAsync()
        {
            var list = await _familiaService.ListarFamiliasIDAsync();            
            return Ok(list);
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarFamiliaAsync([FromBody] AtualizarFamiliaDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();
            await _familiaService.AtualizarFamiliaAsync(dto);
            return Ok(dto);
        }


        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeletarFamiliaAsync([FromRoute] int idFamilia)
        {
            await _familiaService.DeletarFamiliaAsync(idFamilia);
            return NoContent();
        }
    }
}
