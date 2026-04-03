using System;
using System.Threading;

namespace CybersecurityBot
{
    public class Chatbot
    {
        private string userName;
        private AudioPlayer audioPlayer;
        private ResponseHandler responseHandler;
        
        public Chatbot()
        {
            audioPlayer = new AudioPlayer("greeting.wav");
            responseHandler = new ResponseHandler();
        }
        
        public void Start()
        {
            Console.Clear();
            AsciiArt.DisplayLogo();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n[ Starting bot...]");
            audioPlayer.PlayGreeting();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nHello! Welcome to the Cybersecurity Awareness Bot!");
            Thread.Sleep(500);
            
            GetUserName();
            DisplayPersonalizedWelcome();
            StartConversation();
        }
        
        private void GetUserName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n May I have your name? ");
            Console.ForegroundColor = ConsoleColor.White;
            userName = Console.ReadLine();
            
            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" I didn't catch that. What's your name? ");
                Console.ForegroundColor = ConsoleColor.White;
                userName = Console.ReadLine();
            }
        }
        
        private void DisplayPersonalizedWelcome()
        {
            Console.Clear();
            AsciiArt.DisplayLogo();
            AsciiArt.DisplayDivider() ;
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n Welcome, {userName}! ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nI'm your personal Cybersecurity Awareness Assistant.");
            Console.WriteLine("I'm here to help you stay safe and secure online.\n");
            
            AsciiArt.DisplayShield();
            AsciiArt.DisplayDivider();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n You can ask me about:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  • Password safety");
            Console.WriteLine("  • Phishing attacks");
            Console.WriteLine("  • Safe browsing habits");
            Console.WriteLine("  • General cybersecurity tips");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Try asking: 'How are you?' or 'What's your purpose?'");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nType 'exit', 'quit', or 'bye' to end the conversation.\n");
            AsciiArt.DisplayDivider();
        }
        
        private void StartConversation()
        {
            bool running = true;
            
            while (running)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\n[{userName}] > ");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n I didn't quite understand that. Could you rephrase?");
                    continue;
                }
                
                if (responseHandler.IsExitCommand(input))
                {
                    DisplayGoodbye();
                    running = false;
                    break;
                }
                
                string response = responseHandler.GetResponse(input);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n[🤖] ");
                AsciiArt.TypeWriterEffect(response, 20);
                
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(new string('─', 60));
            }
        }
        
        private void DisplayGoodbye()
        {
            Console.Clear();
            AsciiArt.DisplayLogo();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n\nThank you for chatting with me, {userName}!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            AsciiArt.TypeWriterEffect("\nRemember: Stay safe online! ", 40);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nGoodbye! Have a secure day! ");
            Console.ResetColor();
            Thread.Sleep(2000);
        }
    }
}