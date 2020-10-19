using PlsRespond.Classes;
using System;
using System.Dynamic;
using System.Text;
using System.Text.RegularExpressions;

namespace PlsRespond
{
    class Program
    {
        static void ReadCommand(string Message)
        {
            foreach(Regex substr in CommandLibrary.GetList())
            {
                if (substr.IsMatch(Message))
                {
                    Console.WriteLine($"{substr} is a command indeed");
                    return;
                }
            }
            Console.WriteLine("Command not found");
        }
        static void Main(string[] args)
        {
            string Message;
            while (true)
            {
                Console.WriteLine("Type a message or a command or type :wq to exit");
                Message = Console.ReadLine();
                if (Message[0] == '/')
                {
                    ReadCommand(Message);
                }
                else if (Message.Equals(":wq"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Message + " :)");
                }

            }
        }
    }
}
