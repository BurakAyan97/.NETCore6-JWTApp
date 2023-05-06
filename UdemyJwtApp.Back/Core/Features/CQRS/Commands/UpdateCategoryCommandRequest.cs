using MediatR;

namespace UdemyJwtApp.Back.Core.Features.CQRS.Commands
{
    public class UpdateCategoryCommandRequest:IRequest
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
    }
}
