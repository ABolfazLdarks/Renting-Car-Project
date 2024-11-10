using System.IO;

public static class TokenManager
{
    private const string TokenFilePath = "token.txt";

    public static void SaveToken(string token)
    {
        File.WriteAllText(TokenFilePath, token);
    }

    public static string LoadToken()
    {
        if (File.Exists(TokenFilePath))
        {
            return File.ReadAllText(TokenFilePath);
        }
        return null;
    }

    public static void DeleteToken()
    {
        if (File.Exists(TokenFilePath))
        {
            File.Delete(TokenFilePath);
        }
    }
}
