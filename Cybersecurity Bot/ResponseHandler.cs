using System;
using System.Collections.Generic;

namespace CybersecurityBot
{
    public class ResponseHandler
    {
        private Dictionary<string, string> responses;

        public ResponseHandler()
        {
            InitializeResponses();
        }

        private void InitializeResponses()
        {
            responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            responses.Add("how are you", "I'm functioning optimally, thank you for asking! How can I help you stay secure today?");
            responses.Add("what's your purpose", "I'm here to help you learn about cybersecurity best practices and keep you safe online!");
            responses.Add("what can i ask you about", "You can ask me about:\n• Password safety\n• Phishing attacks\n• Safe browsing habits\n• General cybersecurity tips");
            responses.Add("hello", "Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online!");
            responses.Add("hi", "Hi there! Ready to learn about staying safe online?");
            responses.Add("help", "I can help you with cybersecurity topics like:\n- Creating strong passwords\n- Identifying phishing emails\n- Safe browsing practices\n- Protecting your personal information");
            responses.Add("password", "Strong passwords are essential! Tips:\n• Use a mix of uppercase, lowercase, numbers, and symbols\n• Aim for at least 12 characters\n• Never reuse passwords across different sites\n• Consider using a password manager");
            responses.Add("phishing", "Phishing attacks try to trick you! Watch out for:\n• Suspicious email addresses\n• Spelling and grammar errors\n• Urgent requests for information\n• Links that don't match the sender\n• Never click suspicious links!");
            responses.Add("browsing", "Safe browsing tips:\n• Look for HTTPS in the URL\n• Keep your browser updated\n• Avoid clicking pop-up ads\n• Use a reputable ad-blocker\n• Clear cookies regularly");
        }

        public string GetResponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            string lowerInput = input.ToLower().Trim();

            foreach (var kvp in responses)
            {
                if (lowerInput.Contains(kvp.Key))
                {
                    return kvp.Value;
                }
            }

            return GetDefaultResponse();
        }

        private string GetDefaultResponse()
        {
            string[] defaultResponses = {
                "I didn't quite understand that. Could you rephrase?",
                "I'm not sure about that. Try asking about passwords, phishing, or safe browsing!",
                "Let's focus on cybersecurity topics. Would you like to learn about passwords, phishing, or safe browsing?"
            };

            Random rand = new Random();
            return defaultResponses[rand.Next(defaultResponses.Length)];
        }

        public bool IsExitCommand(string input)
        {
            string[] exitCommands = { "exit", "quit", "bye", "goodbye", "end" };

            foreach (string cmd in exitCommands)
            {
                if (input.ToLower().Trim().Equals(cmd))
                    return true;
            }
            return false;
        }
    }
}