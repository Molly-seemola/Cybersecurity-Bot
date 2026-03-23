using System;

namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;

            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}