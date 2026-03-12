using MediatR;
using TodoApp.Application.Presistence.RepositoryInterface;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Features.Todos.Command.AddTodo
{
    public class AddTodoCommandHandler : IRequestHandler<AddTodoCommand, Guid>
    {
        private readonly ITodoRepository _repo;

        public AddTodoCommandHandler(ITodoRepository repo)
        {
            _repo = repo;
        }

        public async Task<Guid> Handle(AddTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = new TodoItem(request.Title, request.Description);

            await _repo.AddAsync(todo);

            return todo.Id;
        }
    }
}
