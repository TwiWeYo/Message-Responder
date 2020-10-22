using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Text.RegularExpressions;

namespace PlsRespond.Classes
{
    class CommandLibrary
    {
        public static List<Command> List { get; } = new List<Command>();
        static CommandLibrary()
        {
            List.Add(new Command("help", Help));
            List.Add(new Command("edit", Edit));
            List.Add(new Command("add", Add));
            List.Add(new Command("remove", Remove));
            List.Add(new Command("exit", Exit));
        }
        public static string Exit()
        {
            Environment.Exit(0);
            return (null);
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
