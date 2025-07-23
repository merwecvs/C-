using TaskTracking.Entities;
using TaskTracking.Entities.Repositories;

namespace TaskTracking.Business.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskrepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskrepository = taskRepository;
        }

        public async Task<List<TaskItem>> GetAllTasksAsync() =>
            await _taskrepository.GetAllAsync();

        public async Task<TaskItem?> GetTaskByIdAsync(int id) =>
            await _taskrepository.GetByIdAsync(id);

        public async Task AddTaskAsync(TaskItem task) =>
            await _taskrepository.AddAsync(task);

        public async Task UpdateTaskAsync(TaskItem task) =>
            await _taskrepository.UpdateAsync(task);

        public async Task DeleteTaskAsync(TaskItem task) =>
            await _taskrepository.DeleteAsync(task);
    }
}