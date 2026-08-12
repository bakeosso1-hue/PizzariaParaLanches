using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Application.DTOs;
using Pizzaria.Application.Interfaces;

namespace Pizzaria.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;
        // -----------------------------------------------------------------

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaDto>>> GetAll()
        {
            var pizzas = await _pizzaService.GetAllAsync();
            return Ok(pizzas);
        }

        // -----------------------------------------------------------------
        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaDto>> GetById(int id)
        {
            var pizza = await _pizzaService.GetByIdAsync(id);

            if (pizza == null)
                return NotFound(new { message = "Pizza não encontrada." });

            return Ok(pizza);
        }
        // Pizzaria.APi\Controllers\PizzaController.cs (adicionado endpoint POST)
        [HttpPost]
        //[Authorize(Roles = "Admin")]
        [AllowAnonymous] // <-- só para testes locais se preferir
        public async Task<ActionResult<PizzaDto>> Create([FromBody] CreatePizzaDto dto)
        {
            var pizza = await _pizzaService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = pizza.Id }, pizza);
        }


        // -----------------------------------------------------------------
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<PizzaDto>> Update(int id, [FromBody] UpdatePizzaDto dto)
        {
            // Garantir que o DTO contenha o Id vindo da rota
            dto.Id = id;

            var pizza = await _pizzaService.UpdateAsync(id, dto);

            if (pizza == null)
                return NotFound(new { message = "Pizza não encontrada." });

            return Ok(pizza);
        }

        // -----------------------------------------------------------------
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _pizzaService.DeleteAsync(id);

            if (!deleted)
                return NotFound(new { message = "Pizza não encontrada." });

            return NoContent();
        }
    }
}
