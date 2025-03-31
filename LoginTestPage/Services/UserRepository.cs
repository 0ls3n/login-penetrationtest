using Microsoft.EntityFrameworkCore;

namespace LoginTestPage.Services;
using LoginTestPage.Models;

public class UserRepository : IUserRepository
{
    private DataContext _context;

    public UserRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task Add(User? user)
    {
        if (user is not null)
        {
            await _context.Users.AddAsync(user);
        }
    }

    public void Update(User? user)
    {
        if (user is not null)
        {
            _context.Users.Update(user);
        }
    }

    public void Delete(User? user)
    {
        if (user is not null)
        {
            _context.Users.Remove(user);
        }
    }

    public async Task<User?> GetById(int id)
    {
        return await _context.Users.FindAsync(id);
    }
}