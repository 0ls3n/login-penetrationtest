using LoginTestPage.Models;
using HashingLibrary;

namespace LoginTestPage.Services;

public class UserManager(IUserRepository userRepository, SignInManager signInManager)
    : IUserManager
{
    public async Task<bool> SignIn(UserDto? user)
    {
         /* Find if the user exists, after check if the hashed password is the same
            as the one on the database. */
         if (user?.Email != null)
         {
             User? userToCheck = await userRepository.GetByEmail(user.Email);
             if (userToCheck is not null)
             {
                 if (user.Password != null)
                 {
                     string hashedPassword = CustomHashing.HashPassword(user.Password);
                     if (userToCheck.HashedPassword == hashedPassword)
                     {
                         signInManager.SignUserIn(user.Email);
                         return true;
                     }
                 }
             }
         }

         return false;
    }

    public void SignOut()
    {
        if (signInManager.Email is not null)
        {
            signInManager.SignUserOut();
        }
    }

    public async Task<bool> Register(UserDto? user)
    {
        /* Convert the plain text password to a hashed password,
           and after that create instance of a new User,
           and add it to the repository. The function should return true,
           if the register is successful */

        if (user is not null)
        {
            string? email = user.Email;
            string password = string.Empty;
            
            List<User>? users = await userRepository.GetAll();

            foreach (User? u in users)
            {
                if (user.Email == u.Email)
                {
                    return false;
                }
            }
            
            if (user?.Password != null)
            {
                password = CustomHashing.HashPassword(user.Password);
            }

            var userToRegister = new User
            {
                Email = email,
                HashedPassword = password
            };

            await userRepository.Add(userToRegister);
        }
        return true;
    }
}





