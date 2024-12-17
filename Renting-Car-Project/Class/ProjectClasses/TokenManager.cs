//using Newtonsoft.Json;
//using System;
//using System.IO;

//public static class TokenManager
//{
//    private const string TokenFilePath = "token.txt";

//    // ذخیره توکن به صورت JSON
//   // ذخیره توکن به صورت JSON
//public static void SaveToken(string token)
//{
//    var tokenData = new
//    {
//        Token = token
//    };

//    string jsonToken = JsonConvert.SerializeObject(tokenData);
//    File.WriteAllText(TokenFilePath, jsonToken);
//}


//    // بارگذاری توکن از فایل
//    public static string LoadToken()
//    {
//        if (File.Exists(TokenFilePath))
//        {
//            return File.ReadAllText(TokenFilePath);
//        }
//        return null;
//    }

//    // حذف توکن
//    public static void DeleteToken()
//    {
//        if (File.Exists(TokenFilePath))
//        {
//            File.Delete(TokenFilePath);
//        }
//    }

//    // استخراج userId از توکن JSON
//    public static int GetUserIdFromToken(string token)
//    {
//        try
//        {
//            var tokenData = JsonConvert.DeserializeObject<dynamic>(token);
//            if (tokenData != null && tokenData.UserId != null)
//            {
//                return int.Parse((string)tokenData.UserId); // تبدیل رشته به عدد (int)
//            }
//        }
//        catch (Exception ex)
//        {
//            throw new Exception("خطا در استخراج userId از توکن: " + ex.Message);
//        }

//        throw new Exception("توکن معتبر نیست یا شامل userId نمی‌باشد.");
//    }
//}
