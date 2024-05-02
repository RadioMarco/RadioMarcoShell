using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    /// <summary>
    /// A Marcoic Inplemantation of Variables to RMS2 without using OOP but rather FOP (File Oriented Programming) 
    /// </summary>
    internal class Variables
    {
        public static string GetDefaultVariables(string variableName)
        {
            switch (variableName)
            {
                //user-home folder.
                case "&home":
                    variableName = Environment.GetEnvironmentVariable("USERPROFILE"); break;
                //Radio Marco logs location
                case "&logs":
                    variableName = Environment.GetEnvironmentVariable("RMS2logs"); break;
                //system root (WINDOWS folder)
                case "&root":
                    variableName = Environment.GetEnvironmentVariable("systemroot"); break;
                //current date
                case "&date":
                    variableName = $"{DateOnly.FromDateTime(DateTime.Now)}"; break;
                //current time
                case "&time":
                    variableName = $"{TimeOnly.FromDateTime(DateTime.Now)}"; break;
                //current date and time
                case "&dati":
                    variableName = $"{DateTime.Now}"; break;
                //Local IP-adress.
                case "&inip":
                    variableName = Network.getLocalIPAddressWithNetworkInterface(NetworkInterfaceType.Wireless80211); break;
                //Username
                case "&user":
                    variableName = Environment.UserName; break;
                //Domain name
                case "&dom":
                    variableName = Environment.UserDomainName; break;
                //Kernel name
                case "&kern":
                    variableName = $"{Environment.OSVersion}"; break;
                //litteraly just Radio Marco Shell 2
                case "&RMS2":
                    variableName = "Radio Marco Shell 2"; break;
                default:
                    GetOwnVariables(variableName);
                    break;
            }
            return variableName;
        }
        /// <summary>
        /// Make your own variables in RMS2
        /// </summary>
        /// <param name="variableName">The name of the variable. Please consider naming a variable &name.</param>
        /// <param name="content">Content of the variable</param>
        public static void SetOwnVariables(string variableName, string content)
        {
            string dir = Environment.GetEnvironmentVariable("RMS2logs");
            Directory.CreateDirectory($"{dir}\\var");
            using StreamWriter swVar = File.AppendText($"{dir}\\var\\{variableName}.rmsvar");
            swVar.Write(content);
            swVar.Close();
        }
        public static string GetOwnVariables(string variableName)
        {
            try
            {
                string dir = Environment.GetEnvironmentVariable("RMS2logs");
                dir += $"/var/{variableName}.rmsvar";
                string[] variableHistory = File.ReadAllLines($"dir"); Thread.Sleep(1000);
                variableName = variableHistory[variableHistory.Length - 1];
            }
            catch (FileNotFoundException)
            {
                //litteraly does nothing, because it doesn't matter

            }

            return variableName;
        }
        public static void DeleteAllVariables()
        {
            string dir = Environment.GetEnvironmentVariable("RMS2logs");
            string[] allVariables = Directory.GetFiles($"{dir}\\var");
            foreach (string variableName in allVariables)
            {
                File.Delete(variableName);
            }
        }
        public static void DeleteAVariable(string variableName)
        {
            string path = Environment.GetEnvironmentVariable("RMS2logs");
            File.Delete($"{path}\\var\\{variableName}.rmsvar");
        }

        public static void VarCommandInterpret(string[] command)
        {
            string directory = Directory.GetCurrentDirectory();
            if (command.Length < 2)
            {
                Error.throwTooLittleArgumentError(command, "var");
            }
            else if (command.Length == 2)
            {
                if (command[1] == "ls" || command[1] == "help")
                {
                    Console.WriteLine("Default Variables:");
                    Console.WriteLine($"    &home: {Environment.GetEnvironmentVariable("USERPROFILE")} - User folder");
                    Console.WriteLine($"    &logs: {Environment.GetEnvironmentVariable("RMS2logs")} - Place where logs are safed");
                    Console.WriteLine($"    &root: {Environment.GetEnvironmentVariable("systemroot")} - Windows root folder");
                    Console.WriteLine($"    &date: {DateOnly.FromDateTime(DateTime.Now)} - Current date");
                    Console.WriteLine($"    &time: {TimeOnly.FromDateTime(DateTime.Now)} - Current time");
                    Console.WriteLine($"    &dati: {DateTime.Now} - Current date and time");
                    Console.WriteLine($"    &inip: {Network.getLocalIPAddressWithNetworkInterface(NetworkInterfaceType.Wireless80211)} - local IP adress");
                    Console.WriteLine($"    &user: {Environment.UserName} - Username");
                    Console.WriteLine($"    &dom : {Environment.UserDomainName} - User Domain");
                    Console.WriteLine($"    &kern: {Environment.OSVersion} - OS Kernel verison");
                    Console.WriteLine($"    &RMS2: Radio Marco Shell 2 - Displays name of this Software");
                }
                if (command[1] == "ls")
                {
                    Console.WriteLine("OwnVariables:");
                    string path = Environment.GetEnvironmentVariable("RMS2logs");
                    path += "\\var";
                    string[] variables = Directory.GetFiles(path);
                    if (variables.Length < 1)
                    {
                        Console.WriteLine("No Data");
                    }
                    else
                    {
                        foreach (string variable in variables)
                        {
                            string[] content = File.ReadAllLines(variable);
                            string[] varPath = variable.Split('/');
                            string[] varEnding = varPath[varPath.Length - 1].Split('.');
                            Console.WriteLine($"{varEnding[0]} = {content[content.Length - 1]}");
                        }

                    }
                    
                }
                Console.WriteLine(GetDefaultVariables(command[1]));
            }
            else
            {
                string path = Environment.GetEnvironmentVariable("RMS2logs");
                try
                {
                    path += "/var";
                    Directory.SetCurrentDirectory(path);
                    Files.WriteInFile(command, true);
                    Directory.SetCurrentDirectory(directory);
                }
                catch (System.IO.DirectoryNotFoundException) 
                {
                    Directory.SetCurrentDirectory(Environment.GetEnvironmentVariable("RMS2logs"));
                    Explorer.MakeDirectory("var");
                    Directory.SetCurrentDirectory(path);
                    Files.WriteInFile(command, true);
                    Directory.SetCurrentDirectory(directory);
                }


            }
        }

    }
}
