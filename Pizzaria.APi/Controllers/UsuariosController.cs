using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Application.DTOs;
using Pizzaria.Application.Interfaces;

namespace Pizzaria.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosService _usuariosService;
        private readonly UserManager<IdentityUser> _userManager;
        // -----------------------------------------------------------------

        public UsuariosController(IUsuariosService usuariosService, UserManager<IdentityUser> userManager)
        {
            _usuariosService = usuariosService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetAll()
        {
            var usuarios = await _usuariosService.GetAllAsync();
            return Ok(usuarios);
        }
        // -----------------------------------------------------------------

        [HttpPost]
        public async Task<ActionResult<UsuarioDto>> Create([FromBody] CreateUsuarioDto dto)
        {
            var (sucess, usuario, error) = await _usuariosService.CreateAsync(dto);
            if (!sucess) return BadRequest(new {message = error});
            return Ok(usuario);
        }
        // -----------------------------------------------------------------

        [HttpDelete("{id}")]
        public async Task<ActionResult> Deleteasync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound(new { message = "Usuário não encontrado." });

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded) 
            {
                var errors = result.Errors.Select(e => e.Description).ToArray();
                return BadRequest(new { message = "Erro ao deletar usuário.", errors });
            }

            return Ok(new {message = "Usuário deletado com sucesso." });

        }
    }
}
