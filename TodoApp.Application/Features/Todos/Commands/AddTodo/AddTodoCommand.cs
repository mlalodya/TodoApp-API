using MediatR;

namespace TodoApp.Application.Features.Todos.Command.AddTodo
{
    public record AddTodoCommand(string Title, string? Description) : IRequest<Guid>;
}
