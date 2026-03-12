using MediatR;
using TodoApp.Application.Dto;

namespace TodoApp.Application.Features.Todos.Query.GetTodo
{
    public record GetTodoQuery() : IRequest<List<TodoDto>>;
}
