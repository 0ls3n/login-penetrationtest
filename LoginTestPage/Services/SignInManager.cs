using LoginTestPage.Models;
namespace LoginTestPage.Services;
public class SignInManager
{
    public string? Email {get; private set;}

    public void SignUserIn(string email)
    {
        this.Email = email;
    }

    public void SignUserOut()
    {
        this.Email = null;
    }

    public bool IsUserSignedIn()
    {
        if (this.Email != null)
        {
            return true;
        }
        
        return false;
    }
}