using TodoApp.Domain.Entities;

namespace TodoApp.Application.Presistence.RepositoryInterface
{
    public interface ITodoRepository
    {
        Task<List<TodoItem>> GetAllAsync();
        Task<TodoItem?> GetByIdAsync(Guid id);
        Task AddAsync(TodoItem item);
        Task DeleteAsync(Guid id);
    }
}
