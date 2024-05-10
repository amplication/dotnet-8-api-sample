namespace MyService.APIs.Dtos;

public class TodoItemDto : TodoItemIdDto
{
    public string? Name { get; set; }

    public bool IsComplete { get; set; }

    public required WorkspaceIdDto WorkspaceId { get; set; }

    public ICollection<AuthorIdDto>? AuthorIds { get; set; }
}
