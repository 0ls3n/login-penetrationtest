using Microsoft.EntityFrameworkCore;
using LoginTestPage.Models;
namespace LoginTestPage.Services;


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
            await _context.SaveChangesAsync();
        }
    }

    public void Update(User? user)
    {
        if (user is not null)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
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

    public async Task<User?> GetByEmail(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
    }

    public async Task<List<User>> GetAll()
    {
        return await _context.Users.ToListAsync();
    }
}