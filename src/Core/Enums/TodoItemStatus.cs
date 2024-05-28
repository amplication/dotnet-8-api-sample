using System.Text.Json.Serialization;

namespace MyService.Core.Enum;

[JsonConverter(typeof(JsonStringEnumConverter<TodoItemStatus>))]
public enum TodoItemStatus
{
    Draft,
    NotStarted,
    InProgress,
    Completed
}
