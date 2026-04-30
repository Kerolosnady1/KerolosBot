# KerolosBot AI 🤖

KerolosBot is a simple, locally-hosted desktop assistant project. It features a modern desktop User Interface built with **C# Windows Forms (.NET 10)**, backed by a lightweight conversational agent written in **Python**. 

The project demonstrates cross-language communication by executing an external Python script from C# and exchanging query/response data via text files.

## 🚀 Features
- **C# / .NET 10 GUI:** A clean Windows form to interact with the bot.
- **Python Backend Engine:** A regex-based intent matcher that parses questions and generates answers.
- **File-based Inter-Process Communication:** Relies on local `.txt` file streams to bridge the gap between the .NET runtime and the Python environment.

## 🛠️ Prerequisites
To run this project on your local machine, you will need:
- [Visual Studio 2026](https://visualstudio.microsoft.com/) (or a compatible IDE)
- [.NET 10 SDK](https://dotnet.microsoft.com/)
- [Python 3.1x](https://www.python.org/downloads/) installed locally

## ⚙️ Setup & Installation
1. Clone this repository:
2. Open the solution in Visual Studio.
3. **Important Path Adjustments:** 
Because this project uses absolute paths, you must update the file paths in both `Form1.cs` and `ai_engine.py` to match your local environment:
- Update the Python executable pathin `Form1.cs` (e.g., `C:\Program Files\Python314\python.exe`).
- Update the `.txt` file locations in both `Form1.cs` and `ai_engine.py`.
4. Build and Run the project via Visual Studio.

## 🎮 How to Use
1. Launch the `KerolosBot` application.
2. Type a message (e.g., "Hello" or "Who are you?") into the toptext box.
3. Click **Enter** to write the query to the system and trigger the Python AI script.
4. Click **Answer** to dynamically read the processed text file and view KerolosBot's response in the main dialogue box.

## 🧠 How it Works
1. **Input:** User writes text in C# Form -> C# writes to `messages4KerolosBot.txt`.
2. **Execution:** C# uses `ProcessStartInfo` to launch `ai_engine.py` in the background.
3. **Processing:** Python reads `messages4KerolosBot.txt`, compares inputs against a regex dictionary, and determines an output.
4. **Output:** Python writes the result to `response4KerolosBot.txt`. C# reads this file and updates the UI UI.

## 👨‍💻 Developer
Developed by **Kerolos Farag**.