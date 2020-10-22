using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PlsRespond.Classes
{
    static class MessageProcessor
    {
        private static string ReadCommand(string Message)
        {
            foreach (Command command in CommandLibrary.List)
            {
                if (command.IsMatch(Message))
                {
                    return command.Execute();
                }
            }
            return ("Command not found");
        }

        private static string GetResponse(string Message)
        {
            return ($"I dunno how to respond to {Message}");
        }
        public static string Process(string message, ref bool isCommand)
        {
            isCommand = false;
            if (message[0] == '/')
            {
                isCommand = true;
                return (ReadCommand(message));
            }
            else
                return GetResponse(message);
        }
    }
}
