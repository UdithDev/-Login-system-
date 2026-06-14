using BankAuthApi.Models;

namespace BankAuthApi.Repositories;
public interface IUserRepository
{
    Task<User?> GetByUsernameAsync(string username);
    Task<User?> GetByNICAsync(string nic);

    Task AddUserAsync(User user);
}