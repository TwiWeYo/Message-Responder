using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Text.RegularExpressions;

namespace PlsRespond.Classes
{
    class CommandLibrary
    {
        private static List<Command> ListCommands = new List<Command>();
        static CommandLibrary()
        {
            ListCommands.Add(new Command("help", Help));
            ListCommands.Add(new Command("edit", Edit));
            ListCommands.Add(new Command("add", Add));
            ListCommands.Add(new Command("remove", Remove));
        }
        public static List<Command> GetList() => ListCommands;
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
