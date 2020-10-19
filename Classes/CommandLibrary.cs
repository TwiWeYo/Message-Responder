using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace PlsRespond.Classes
{
    public class CommandLibrary
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
                    CommandList.Add(new Regex($@"^{line}(\s\w)*$"));
            }
        }
        public static List<Regex> GetList() => CommandList;
    }
}
