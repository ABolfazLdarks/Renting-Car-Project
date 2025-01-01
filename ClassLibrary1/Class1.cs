

namespace ClassLibrary1
{
    public class Class1
    {


[RunInstaller(true)]
    public class DatabaseInstaller : Installer
    {
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);

            // فایل اسکریپت را از پارامترها می‌گیریم
            string scriptPath = Context.Parameters["ScriptPath"];

            if (!string.IsNullOrEmpty(scriptPath) && File.Exists(scriptPath))
            {
                try
                {
                    ExecuteSqlScript(scriptPath);
                    Console.WriteLine("اسکریپت SQL با موفقیت اجرا شد.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("خطا در اجرای اسکریپت SQL: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("فایل اسکریپت پیدا نشد.");
            }
        }

        private void ExecuteSqlScript(string scriptPath)
        {
            // اتصال به دیتابیس
            string connectionString = @"Server=.\SQLEXPRESS;Integrated Security=True;";
            string script = File.ReadAllText(scriptPath);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(script, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
}