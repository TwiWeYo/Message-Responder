using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PlsRespond.Classes
{
    public class Command
    {
        private Regex _name;
        private Func<string> _command;
        public Command(string name, Func<string> command)
        {
            _name = new Regex($@"^/{name}(\s\w*)*$");
            _command = command;
        }
        public bool IsMatch(string message) => _name.IsMatch(message);
        public string Execute() => _command?.Invoke();
    }
}
