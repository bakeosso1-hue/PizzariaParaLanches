using Microsoft.AspNetCore.Mvc;

namespace Pizzaria.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EsfinhaController : ControllerBase
    {
        private readonly IEsfinhaService _esfinhaService;
        // -----------------------------------------------------------------

        public EsfinhaController(IEsfinhaService esfinhaService)
        {
            _esfinhaService = esfinhaService;
        }

        [HttpGet]
        public async Task<IActionResult<IEnumerable<EsfihaDto>>> GetAll()
        {
            var esfihas = await _esfinhaService.GetAllAsync();
            return Ok(esfihas);
        }
        // -----------------------------------------------------------------
        [HttpGet("{id}")]
        public async Task<IActionResult<EsfinhaDto>> GetById(int id)
        {
            var esfinha = await _esfinhaService.GetByIdAsync(id);
            if (esfinha == null)
                return NotFound(new { message = "Esfinha não encontrada." });
            return Ok(esfinha);
        }

        // -----------------------------------------------------------------

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult<EsfinhaDto>> Create([FromBody] CreateEsfinhaDto dto)
        {
            var esfinha = await _esfinhaService.CreateAsync(dto);

            return CreatedAtAction(nameof(GetAll), new { id = esfinha.Id }, esfinha);
        }
        // -----------------------------------------------------------------

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult<EsfinhaDto>> Update(int id, [FromBody] UpdateEsfinhaDto dto)
        {
            var esfinha = await _esfinhaService.UpdateAsync(id, dto);
            if (esfinha == null)
                return NotFound(new { message = "Esfinha não encontrada." });
            return Ok(esfinha);
        }
    }
}
