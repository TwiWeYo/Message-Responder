using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PlsRespond.Classes
{
    public class Command
    {
        private Regex _name;
        public delegate string ExecCommand();

        private ExecCommand _command;
        public Command(string name, ExecCommand command)
        {
            _name = new Regex($@"^/{name}(\s\w*)*$");
            _command = command;
        }
        public bool IsMatch(string message) => _name.IsMatch(message);
        public string Execute() => _command?.Invoke();
    }
}
