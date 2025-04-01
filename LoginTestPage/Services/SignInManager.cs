using LoginTestPage.Models;
namespace LoginTestPage.Services;
public class SignInManager
{
    public string? Email {get; set;}

    public void SignUserIn(string email)
    {
        this.Email = email;
    }

    public void SignUserOut()
    {
        this.Email = null;
    }
}