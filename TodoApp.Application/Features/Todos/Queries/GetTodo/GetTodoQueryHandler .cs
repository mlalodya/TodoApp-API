using MediatR;
using TodoApp.Application.Dto;
using TodoApp.Application.Presistence.RepositoryInterface;

namespace TodoApp.Application.Features.Todos.Query.GetTodo
{
    public class GetTodoQueryHandler : IRequestHandler<GetTodoQuery, List<TodoDto>>
    {
        private readonly ITodoRepository _repo;

        public GetTodoQueryHandler(ITodoRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<TodoDto>> Handle(GetTodoQuery request, CancellationToken cancellationToken)
        {
            var todos = await _repo.GetAllAsync();

            return todos.Select(t => new TodoDto
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                CreatedAt = t.CreatedAt
            }).ToList();
        }
    }
}
