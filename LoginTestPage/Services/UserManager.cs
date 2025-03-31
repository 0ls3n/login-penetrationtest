using LoginTestPage.Models;

namespace LoginTestPage.Services;

public class UserManager : IUserManager
{
    private readonly IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public void SignIn(User? user)
    {
        throw new NotImplementedException();
    }

    public void SignOut()
    {
        throw new NotImplementedException();
    }

    public void Register(User? user)
    {
        
    }
}