using System;
using System.IO;

public static class UserSession
{
    private static string userSessionFilePath = "userSession.txt"; 
    private const string UserIdKey = "UserId";
    private const string IsLoggedInKey = "IsLoggedIn";

    public static void SaveUserSession(int userId, bool isLoggedIn)
    {
        string sessionData = $"{UserIdKey}={userId}\n{IsLoggedInKey}={isLoggedIn}";
        File.WriteAllText(userSessionFilePath, sessionData);
    }

    public static UserSessionData LoadUserSession()
    {
        if (File.Exists(userSessionFilePath))
        {
            string sessionData = File.ReadAllText(userSessionFilePath);
            string[] lines = sessionData.Split('\n');

            int userId = -1;
            bool isLoggedIn = false;

            foreach (string line in lines)
            {
                if (line.StartsWith(UserIdKey))
                {
                    int.TryParse(line.Split('=')[1], out userId);
                }
                else if (line.StartsWith(IsLoggedInKey))
                {
                    bool.TryParse(line.Split('=')[1], out isLoggedIn);
                }
            }

            if (userId != -1 && isLoggedIn)
            {
                return new UserSessionData { UserId = userId, IsLoggedIn = isLoggedIn };
            }
        }
        return null; 
    }

    public static void Logout()
    {
        if (File.Exists(userSessionFilePath))
        {
            File.Delete(userSessionFilePath); 
        }
    }
}

public class UserSessionData
{
    public int UserId { get; set; }
    public bool IsLoggedIn { get; set; }
}
