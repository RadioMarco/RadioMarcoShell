using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts.DataProvider;

namespace RMS2
{
    internal class aliasInterpret
    {
        public static string commandTranslater(string command)
        {
            if (command == "ls")
                command = "list";
            if (command == "la")
                command = "list";
            if (command == "cd")
                command = "changedirectory";
            if (command == "mkdir")
                command = "makedirectory";
            if (command == "rmdir")
                command = "removedirectory";
            if (command == "del")
                command = "removedirectory";
            if (command == "echo")
                command = "print";
            if (command == "rm")
                command = "remove";
            if (command == "hp")
                command = "help";
            if (command == "cl")
                command = "clear";
            if (command == "cat")
                command = "read";
            if (command == "colour")
                command = "color";
            if (command == "clr")
                command = "color";
            if (command == "rm")
                command = "removefile";
            if (command == "mv")
                command = "movefile";
            if (command == "./")
                command = "open";
            if (command == "nano")
                command = "write";

            return command;
        }
    }
}
