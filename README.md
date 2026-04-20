# Cybersecurity Awareness Bot - Part 1

## Overview
A console chatbot that teaches cybersecurity through conversation with voice greeting, ASCII art, and personalized responses.

## Features
-  Voice greeting (greeting.wav)
-  ASCII art logo and shield
-  Personalized chat (asks for your name)
-  Answers about passwords, phishing, safe browsing
-  Handles invalid inputs gracefully
-  Colored text + typing effect
-  Clean code with multiple classes

## Files
- Program.cs - Main entry
- Chatbot.cs - Conversation flow
- ResponseHandler.cs - Q&A logic
- AsciiArt.cs - Visual elements
- AudioPlayer.cs - Voice greeting

## How to Run
1. `dotnet build`
2. `dotnet run`
3. Add `greeting.wav` for voice (optional)
] May I have your name? John
 Welcome, John! 

[John] > How are you?
[] I'm functioning optimally!

[John] > Tell me about passwords
[] Strong passwords need letters, numbers, and symbols.

[John] > bye
[] Goodbye John! Stay safe! 

text

## Commands
- `exit`, `quit`, `bye` - Exit program
- `help` - Show topics
- Any question - Get answer

## Requirements
- .NET 6.0 or later
- Windows (for audio)

## Author
Seemola Mamoloko Molly
09-04-2026


