using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;

namespace UdemyJwtApp.Back.Core.Features.CQRS.Queries
{
    public class GetCategoryQueryRequest:IRequest<CategoryListDto?>
    {
        public GetCategoryQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
