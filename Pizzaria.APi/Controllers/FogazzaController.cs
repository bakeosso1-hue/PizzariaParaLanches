using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Pizzaria.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FogazzaController : ControllerBase
    {
        private readonly IFogazzaService _fogazzaService;
        // -----------------------------------------------------------------

        public FogazzaController(IFogazzaService fogazzaService)
        {
            _fogazzaService = fogazzaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FogazzaDto>>> GetAll()
        {
            var fogazzas = await _fogazzaService.GetAllAsync();
            return Ok(fogazzas);
        }
        // -----------------------------------------------------------------


        [HttpGet("{id}")]
        public async Task<ActionResult<FogazzaDto>> GetById(int id)
        {
            var fogazza = await _fogazzaService.GetByIdAsync(id);
            if (fogazza == null)
                return NotFound(new { message = "Fogazza não encontrada." });
            return Ok(fogazza);
        }
        // -----------------------------------------------------------------

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<FogazzaDto>> Create([FromBody] CreateFogazzaDto dto)
        {
            var fogazza = await _fogazzaService.CreateAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = fogazza.Id }, fogazza);
        }
        // -----------------------------------------------------------------

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<FogazzaDto>> Update(int id, [FromBody] UpdateFogazzaDto dto)
        {
            var fogazza = await _fogazzaService.UpdateAsync(id, dto);
            if (fogazza == null)
                return NotFound(new { message = "Fogazza não encontrada." });
            return Ok(fogazza);
        }
    }
}
