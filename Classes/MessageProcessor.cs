using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PlsRespond.Classes
{
    static class MessageProcessor
    {
        public delegate string PerformCommand();

        private static string ReadCommand(string Message)
        {
            foreach (Regex substr in CommandLibrary.GetList())
            {
                if (substr.IsMatch(Message))
                {
                    PerformCommand performer = null;
                    CommandLibrary.FindCommand(Message.Substring(0, Message.IndexOf(" ")), ref performer);
                    return(performer?.Invoke());
                }
            }
            return ("Command not found");
        }

        private static string GetResponse(string Message)
        {
            return ("I dunno");
        }
        public static string Process(string Message)
        {
            if (Message[0] == '/')
                return (ReadCommand(Message));
            else
                return GetResponse(Message);
        }
    }
}
