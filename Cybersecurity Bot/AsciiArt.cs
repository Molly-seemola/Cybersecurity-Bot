using System;
using System.Threading;

namespace CybersecurityBot
{
    public static class AsciiArt
    {
        // Displays the main logo
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Set color to cyan
            string logo = @"
    ╔══════════════════════════════════════════════════════════════════════════╗
    ║                                                                          ║
    ║    ██████╗██╗   ██╗██████╗ ███████╗██████╗ ███████╗ ██████╗███████╗     ║
    ║   ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝██╔════╝██╔════╝     ║
    ║   ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝█████╗  ██║     █████╗       ║
    ║   ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██╔══╝  ██║     ██╔══╝       ║
    ║   ╚██████╗   ██║   ██████╔╝███████╗██║  ██║███████╗╚██████╗███████╗     ║
    ║    ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝ ╚═════╝╚══════╝     ║
    ║                                                                          ║
    ║                      █████╗ ██╗    ██╗ █████╗ ██████╗ ███████╗          ║
    ║                     ██╔══██╗██║    ██║██╔══██╗██╔══██╗██╔════╝          ║
    ║                     ███████║██║ █╗ ██║███████║██████╔╝███████╗          ║
    ║                     ██╔══██║██║███╗██║██╔══██║██╔══██╗╚════██║          ║
    ║                     ██║  ██║╚███╔███╔╝██║  ██║██║  ██║███████║          ║
    ║                     ╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝          ║
    ║                                                                          ║
    ║                     [ CYBERSECURITY AWARENESS BOT ]                      ║
    ║                                                                          ║
    ╚══════════════════════════════════════════════════════════════════════════╝";

            Console.WriteLine(logo);
            Console.ResetColor(); // Reset to default color
        }

        // Displays a decorative shield
        public static void DisplayShield()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string shield = @"
        ╔════════════════════════════════════╗
        ║         🔒  SECURE  🔒            ║
        ║      Stay Safe Online!            ║
        ╚════════════════════════════════════╝";
            Console.WriteLine(shield);
            Console.ResetColor();
        }

        // Displays a divider line
        public static void DisplayDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('═', 80)); // 80 equal signs
            Console.ResetColor();
        }

        // Creates a typing effect - prints text one character at a time
        public static void TypeWriterEffect(string text, int delay = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay); // Wait between each character
            }
            Console.WriteLine(); // New line after text
        }
    }
}