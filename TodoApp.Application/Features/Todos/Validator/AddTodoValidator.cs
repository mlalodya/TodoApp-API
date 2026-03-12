using FluentValidation;
using TodoApp.Application.Features.Todos.Command.AddTodo;

namespace TodoApp.Application.Features.Todos.Validator
{
    public class AddTodoValidator : AbstractValidator<AddTodoCommand>
    {
        public AddTodoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .MaximumLength(200);

            RuleFor(x => x.Description)
                .MaximumLength(1000);
        }
    }
}
