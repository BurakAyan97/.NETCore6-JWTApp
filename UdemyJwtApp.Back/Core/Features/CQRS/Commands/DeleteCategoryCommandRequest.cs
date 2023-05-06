using MediatR;

namespace UdemyJwtApp.Back.Core.Features.CQRS.Commands
{
    public class DeleteCategoryCommandRequest:IRequest
    {
        public DeleteCategoryCommandRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
        
    }
}
