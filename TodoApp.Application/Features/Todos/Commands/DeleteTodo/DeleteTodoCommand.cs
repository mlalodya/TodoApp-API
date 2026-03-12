using MediatR;

namespace TodoApp.Application.Features.Todos.Command.DeleteTodo
{
    public record DeleteTodoCommand(Guid Id) : IRequest;
}
