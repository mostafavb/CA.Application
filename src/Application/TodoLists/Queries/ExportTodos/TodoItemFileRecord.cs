using CA.Application.Application.Common.Mappings;
using CA.Application.Domain.Entities;

namespace CA.Application.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
