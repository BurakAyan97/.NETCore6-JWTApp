using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;

namespace UdemyJwtApp.Back.Core.Features.CQRS.Queries
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDtp>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
