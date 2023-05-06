using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using UdemyJwtApp.Back.Core.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Features.CQRS.Queries;
using UdemyJwtApp.Back.Infrastructure.Tools;

namespace UdemyJwtApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterUserCommandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(CheckUserQueryRequest request)
        {
            var dto = await _mediator.Send(request);

            if (dto.IsExist)
                return Created("", JwtTokenGenerator.GenerateToken(dto));
            else
                return BadRequest("Kullanıcı adı veya sifre hatali");
        }
    }
}
