using System;

namespace CybersecurityBot
{
    public class AudioPlayer
    {
        private string audioFilePath;

        public AudioPlayer(string filePath)
        {
            audioFilePath = filePath;
            // Audio will be added later
        }

        public void PlayGreeting()
        {
            // Simple text greeting while we fix audio
            Console.WriteLine("\n[🎵] Welcome message:");
            Console.WriteLine("Hello! Welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("I'm here to help you stay safe online.");
        }
    }
}