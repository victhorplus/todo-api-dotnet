namespace TodoApi.Models;

public class TodoItem {
    public long Iid { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}