namespace HashingLibrary;

public class CustomHashing
{
    public static string HashPassword(string password)
    {
        int hash = 0;

        foreach (char c in password)
        {
            hash = (hash * 31 + c) % int.MaxValue;
        }

        return hash.ToString("X");
    }
}