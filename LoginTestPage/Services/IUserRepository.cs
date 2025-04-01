using LoginTestPage.Models;
namespace LoginTestPage.Services;


public interface IUserRepository
{
    public Task Add(User? user);
    public void Update(User? user);
    public void Delete(User user);
    public Task<User?> GetById(int id);
    public Task<User?> GetByEmail(string email);
    public Task<List<User>> GetAll();
}