using MediatR;
using TodoApp.Application.Presistence.RepositoryInterface;

namespace TodoApp.Application.Features.Todos.Command.DeleteTodo
{
    public class DeleteTodoCommandHandler : IRequestHandler<DeleteTodoCommand>
    {
        private readonly ITodoRepository _repo;

        public DeleteTodoCommandHandler(ITodoRepository repo)
        {
            _repo = repo;
        }

        public async Task Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = await _repo.GetByIdAsync(request.Id);

            if (todo == null)
                throw new KeyNotFoundException("Todo not found");

            await _repo.DeleteAsync(request.Id);
        }
    }
}
