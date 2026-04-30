'''
This bot is Kerolos Bot power by Kerolos Farag for self projects to help the users in any project
that Kerolos Bot work with.
Also this chatbot works via files system knows as (Inter-process communication via files)
for reviewing the file messages made by another program and return response in another file.
SO this makes the file works seriesly one creates the messages file and one review it and made another
one with response.
EX: 1ST program (Create Messages File) -> 2ND program (Read Messages File) -> 2ND Program 
(Create Responses File) -> 1ST (Program Review Responses File) -> Response Pop-up for User Successfully.
This program solving File Locking that one file Sends-and-Recieves at once and the JSON dificullty,
to make it twist files (slower but easier and efficient).
This called MiddleMan-To-MiddleMan Process
'''
import re, os # regular expression

def get_response(question):

    brain = {
        r"hi|hello" : "Hello, This is Kerolos Bot. How are you?",
        r"who are you|who": "This is an AI sample, power by Kerolos Farag",
        r"fine | good" : "Good to hear",
        r"" : "",
        # Key-Value -> Message-Response (Here)

    }

    for pattern, response in brain.items():
        if re.search(pattern, question):
            return response
        
    return "Sorry, not in my dictionary ;("
    


with open(os.path.join('messages4KerolosBot.txt'), 'rt') as readFile:
    with open('response4KerolosBot.txt', 'wt') as writeFile:
        for line in readFile:
            writeFile.write(f"User: {line}\n")
            writeFile.write(f"Kerolos Bot: {get_response(line)}\n")
