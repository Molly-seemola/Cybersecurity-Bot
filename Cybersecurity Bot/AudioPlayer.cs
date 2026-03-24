using System;
using System.IO;
using System.Media;

namespace CybersecurityBot
{
    public class AudioPlayer
    {
        private string audioFilePath;

        public AudioPlayer(string filePath)
        {
            audioFilePath = FindAudioFile(filePath);
        }

        private string FindAudioFile(string fileName)
        {
            // Get the current output directory (where .exe runs)
            string currentDir = Environment.CurrentDirectory;
            Console.WriteLine($"[DEBUG] Current directory: {currentDir}");

            // Check in current directory first
            if (File.Exists(Path.Combine(currentDir, fileName)))
                return Path.Combine(currentDir, fileName);

            // Check in project root (two levels up from output)
            string projectRoot = Path.GetFullPath(Path.Combine(currentDir, "..", "..", ".."));
            string projectFile = Path.Combine(projectRoot, fileName);
            if (File.Exists(projectFile))
                return projectFile;

            // Check for any WAV file in project
            if (Directory.Exists(projectRoot))
            {
                string[] wavFiles = Directory.GetFiles(projectRoot, "*.wav", SearchOption.AllDirectories);
                if (wavFiles.Length > 0)
                {
                    Console.WriteLine($"[DEBUG] Found WAV: {wavFiles[0]}");
                    return wavFiles[0];
                }
            }

            return fileName;
        }

        public void PlayGreeting()
        {
            try
            {
                if (File.Exists(audioFilePath))
                {
                    Console.WriteLine($"\n[🎵] Playing greeting from: {Path.GetFileName(audioFilePath)}");

                    using (SoundPlayer player = new SoundPlayer(audioFilePath))
                    {
                        player.PlaySync(); // Wait for audio to finish
                    }

                    Console.WriteLine("[✓] Greeting complete!");
                }
                else
                {
                    Console.WriteLine($"\n[⚠️] Audio file not found: {audioFilePath}");
                    Console.WriteLine("[🎵] Using text greeting instead:");
                    ShowTextGreeting();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[❌] Audio error: {ex.Message}");
                Console.WriteLine("[🎵] Using text greeting instead:");
                ShowTextGreeting();
            }
        }

        private void ShowTextGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║  🔒  CYBERSECURITY AWARENESS BOT  🔒               ║");
            Console.WriteLine("║  Your Personal Guide to Online Safety              ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nHello! Welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("I'm here to help you stay safe online.\n");
            Console.ResetColor();
        }
    }
}