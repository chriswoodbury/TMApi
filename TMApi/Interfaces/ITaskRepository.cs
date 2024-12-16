using TMApi.Models;

namespace TMApi.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAllTasks();

        Task<TaskItem> GetTaskById(int id);

        Task<bool> AddTask(TaskItem taskItem);

        Task<bool> UpdateTask(int id, TaskItem taskItem);

        Task<bool> DeleteTask(int id);
    }
}
