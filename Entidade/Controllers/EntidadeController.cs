using Entidade.Domain.Command;
using Entidade.Domain.Interfaces;
using Entidade.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entidade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntidadeController : ControllerBase
    {
        private readonly IEntidadeService _entidadeService;
        public EntidadeController(IEntidadeService entidadeService)
        {
            _entidadeService = entidadeService;
        }

        [HttpPost]
        [Route("CadastrarEntidade")]
        public async Task<IActionResult> PostAsync(EntidadeCommand command)
        {
            return Ok(await _entidadeService.PostAsync(command));
        }
    }
}
