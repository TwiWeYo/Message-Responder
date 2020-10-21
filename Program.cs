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

        private static void ConsoleDisplay(string Message) => Console.WriteLine(Message);
        static void Main(string[] args)
        {
            DisplayMessage mes = ConsoleDisplay;
            while (true)
            {
                Console.WriteLine("Type a message or a command or type /exit to exit");
                mes(MessageProcessor.Process(Console.ReadLine() + " "));

            }
        }
    }
}
