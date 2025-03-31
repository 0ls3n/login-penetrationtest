using LoginTestPage.Models;

namespace LoginTestPage.Services;

public interface IUserManager
{
    public void SignIn(User? user);
    public void SignOut();
    public void Register(User? user);
}