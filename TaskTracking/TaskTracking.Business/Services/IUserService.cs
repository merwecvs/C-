using System.Collections.Generic;
using System.Threading.Tasks;
using TaskTracking.Entities;

namespace TaskTracking.Business.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAllAsync();
        Task<User> GetUserByIdAsync(int id);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);

        Task<User> GetUserByUsernameAsync(string username);

    }
}