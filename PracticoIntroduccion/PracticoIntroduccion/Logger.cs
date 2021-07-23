using System;

namespace PracticoIntroduccion
{
    public class Logger
    {
        public static void Error(Exception ex)
        {
            Logger.Error(ex.Message);
        }

        public static void Error(string errorMessage)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ForegroundColor = currentColor;
        }
    }
}