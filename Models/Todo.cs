namespace TodoAppMT.Models;

public class Todo {
    public int Id { get; set; }
    public string? IdentityUserId { get; set; }  
    public string? Title { get; set; }
    public bool IsCompleted { get; set; }
}