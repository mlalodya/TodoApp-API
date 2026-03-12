namespace TodoApp.Domain.Entities
{
    public class TodoItem
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public TodoItem(string title, string? description)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty");

            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
