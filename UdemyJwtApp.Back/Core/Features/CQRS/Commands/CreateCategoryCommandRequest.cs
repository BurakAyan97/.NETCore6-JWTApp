using MediatR;

namespace UdemyJwtApp.Back.Core.Features.CQRS.Commands
{
    public class CreateCategoryCommandRequest : IRequest
    {
        public string? Definition { get; set; }
    }
}
