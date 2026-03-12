namespace TodoApp.Application.Dto
{
    public class TodoDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
