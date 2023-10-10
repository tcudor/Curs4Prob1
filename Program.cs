

namespace Curs4Prob1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mesaj("High", "High");
            Mesaj("Warning", "Warning");
            Mesaj("Info", "Info");
            Mesaj("Debug", "Debug");
        }
        public static void Mesaj(string severity, string message)
        {
            ConsoleColor textColor;

            switch (severity.ToLower())
            {
                case "high":
                    textColor = ConsoleColor.Red;
                    break;
                case "warning":
                    textColor = ConsoleColor.Yellow;
                    break;
                case "info":
                    textColor = ConsoleColor.White;
                    break;
                case "debug":
                    textColor = ConsoleColor.Gray;
                    break;
                default:
                    textColor = ConsoleColor.Gray;
                    break;
            }

            Console.ForegroundColor = textColor;
            Console.WriteLine($"{severity}: {message}");
            Console.ResetColor();
        }
    }

}