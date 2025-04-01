using LoginTestPage.Models;

namespace LoginTestPage.Services;

public interface IUserManager
{
    public Task<bool> SignIn(UserDto? user);
    public void SignOut();
    public Task<bool> Register(UserDto? user);
}