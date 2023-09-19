namespace todo.Models
{
    public class TodoModel
    {
        public required string title { get; set; }
        public string? description { get; set; }
        public bool isDone { get; set; } = false;
        public DateTime createTime { get; set; } = DateTime.Now;
    }
}
