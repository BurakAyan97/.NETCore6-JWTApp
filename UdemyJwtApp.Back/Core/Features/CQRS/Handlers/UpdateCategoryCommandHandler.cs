using MediatR;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;
using UdemyJwtApp.Back.Core.Features.CQRS.Commands;

namespace UdemyJwtApp.Back.Core.Features.CQRS.Handlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest>
    {
        private readonly IRepository<Category> _categoryRepository;

        public UpdateCategoryCommandHandler(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await _categoryRepository.GetByIdAsync(request.Id);
            if (updatedEntity is not null)
            {
                updatedEntity.Definition = request.Definition;
                await _categoryRepository.UpdateAsync(updatedEntity);
            }
            return Unit.Value;
        }
    }
}
