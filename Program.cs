using PlsRespond.Classes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace PlsRespond
{
    class Program
    {
        delegate void DisplayMessage(string Message);

        private static void ConsoleDisplay(string Message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Message);
            Console.ResetColor();
        }

        private static void ResponseDisplay(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Message);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            DisplayMessage display;
            string message;
            bool isCommand = true;
            while (true)
            {
                ConsoleDisplay("Type a message or a command or type /exit to exit");
                message = (MessageProcessor.Process(Console.ReadLine(), ref isCommand));
                if (isCommand)
                    display = ConsoleDisplay;
                else
                    display = ResponseDisplay;
                display(message);
            }
        }
    }
}
