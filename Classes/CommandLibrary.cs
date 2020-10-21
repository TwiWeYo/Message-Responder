using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Text.RegularExpressions;

namespace PlsRespond.Classes
{
    class CommandLibrary
    {
        private static string path;
        private static List<Regex> CommandList = new List<Regex>();
        static CommandLibrary()
        {
            path = @"Files\commands.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    CommandList.Add(new Regex($@"^/{line}(\s\w*)*$"));
            }
        }
        public static List<Regex> GetList() => CommandList;

        public static void FindCommand(string Command, ref MessageProcessor.PerformCommand handler)
        {
            switch (Command)
            {
                case "/edit":
                    handler = Edit;
                    break;
                case "/exit":
                    Environment.Exit(0);
                    break;
                case "/add":
                    handler = Add;
                    break;
                case "/remove":
                    handler = Remove;
                    break;
                case "/help":
                    handler = Help;
                    break;
                default:
                    handler = Why;
                    break;
            }
        }
        public static string Why()
        {
            return ("Why?");
        }
        public static string Help()
        {
            return ("Helpful, isn't it?");
        }
        public static string Edit()
        {
            return ("I can't edit yet");
        }
        public static string Add()
        {
            return ("I can't add yet");
        }

        public static string Remove()
        {
            return ("Remove me from life instead");
        }
    }
}
