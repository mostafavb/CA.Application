using CA.Application.Application.TodoLists.Queries.ExportTodos;

namespace CA.Application.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
