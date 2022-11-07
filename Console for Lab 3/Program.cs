using static System.Console;
using Library_For_Laboration3;

namespace ConsoleLab3
{
    public class Program { 
        private static string FolderPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Laboration3";

        public static void Main(string[] args)
        {
            

            foreach (string L in args)
            {
                WriteLine(L);
            }
            
        }
        private void CheckFonderExists()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
        }
    }

}