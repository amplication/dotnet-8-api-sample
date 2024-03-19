
using MyService.APIs.Todo.Dtos;
using MyService.APIs.Workspace.Dtos;

namespace MyService.APIs.Author.Dtos;

public class AuthorDto
{
    public long Id { get; set; }
    public string? Name { get; set; }

    public WorkspaceDto? Workspace { get; }
    public ICollection<TodoItemDto>? TodoItems { get; }
}