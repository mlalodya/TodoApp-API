using TodoApp.Application.Presistence.RepositoryInterface;
using TodoApp.Domain.Entities;

namespace TodoApp.Infrastructure.Repositories
{
    public class InMemoryTodoRepository : ITodoRepository
    {
        private static readonly List<TodoItem> _todos = new();

        public Task<List<TodoItem>> GetAllAsync()
        {
            return Task.FromResult(_todos.ToList());
        }

        public Task<TodoItem?> GetByIdAsync(Guid id)
        {
            return Task.FromResult(_todos.FirstOrDefault(x => x.Id == id));
        }

        public Task AddAsync(TodoItem item)
        {
            _todos.Add(item);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            var todo = _todos.FirstOrDefault(x => x.Id == id);

            if (todo != null)
                _todos.Remove(todo);

            return Task.CompletedTask;
        }
    }
}
