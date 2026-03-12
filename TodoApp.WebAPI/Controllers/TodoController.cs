using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Features.Todos.Command.AddTodo;
using TodoApp.Application.Features.Todos.Command.DeleteTodo;
using TodoApp.Application.Features.Todos.Query.GetTodo;

namespace TodoApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TodoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            var result = await _mediator.Send(new GetTodoQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodo([FromBody] AddTodoCommand command)
        {
            var id = await _mediator.Send(command);
            return Created($"/api/todos/{id}", id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(Guid id)
        {
            await _mediator.Send(new DeleteTodoCommand(id));
            return NoContent();
        }
    }
}
