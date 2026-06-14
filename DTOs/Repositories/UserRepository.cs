using BankAuthApi.DB;
using BankAuthApi.Models;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.EntityFrameworkCore;



namespace BankAuthApi.Repositories;

public class UserRepository : IUserRepository
{

    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetByUsernameAsync(string username)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
    }

    public async Task<User?> GetByNICAsync(string nic)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.NIC== nic);
    }

    public async Task AddUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }


}