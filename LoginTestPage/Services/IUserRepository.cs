namespace LoginTestPage.Services;
using LoginTestPage.Models;

public interface IUserRepository
{
    public Task Add(User? user);
    public void Update(User? user);
    public void Delete(User user);
    public Task<User?> GetById(int id);
}