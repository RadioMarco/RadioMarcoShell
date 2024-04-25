using System;
using System.Collections.Generic;
using System.Linq;
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
                    variableName = Environment.GetEnvironmentVariable("USERPROFILE");break;
                    //Radio Marco logs location
                case "&logs":
                    variableName = Environment.GetEnvironmentVariable("RMS2logs"); break;
                //system root (WINDOWS folder)
                case "&root":
                    variableName= Environment.GetEnvironmentVariable("systemroot");break;
                //current date
                case "&date":
                    variableName = $"{DateOnly.FromDateTime(DateTime.Now)}";break;
                //current time
                case "&time":
                    variableName = $"{TimeOnly.FromDateTime(DateTime.Now)}";break;
                //current date and time
                case "&dati":
                    variableName = $"{DateTime.Now}";break ;
                    //Local IP-adress.
                case "&inip":
                    variableName = $"{Network.getLocalIPAddressWithNetworkInterface}";break;
                    //Username
                case "&user":
                    variableName = Environment.UserName ;break;
                    //Domain name
                case "&dom":
                    variableName = Environment.UserDomainName; break;
               //Kernel name
                case "&kern":
                    variableName = $"{Environment.OSVersion}";break;
                    //litteraly just Radio Marco Shell 2
                case "&RMS2":
                    variableName = "Radio Marco Shell 2"; break;
                default:
                    //GetOwnVariables(variableName);
                    break;
            }
            return variableName;
        }
        /// <summary>
        /// Make your own variables in RMS2
        /// </summary>
        /// <param name="variableName">The name of the variable. Please consider naming a variable &name.</param>
        /// <param name="content">Content of the variable</param>
        public static void SetOwnVariables(string variableName,string content)
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
                string[] variableHistory = File.ReadAllLines($"{dir}\\var\\{variableName}.rmsvar");Thread.Sleep(1000);  
                variableName = variableHistory[variableHistory.Length - 1];
            }
            catch (FileNotFoundException)
            {
                Log.Message($"{variableName} is no variable");
               
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
            File.Delete($"{Environment.GetEnvironmentVariable("RMS2logs")}\\var\\{variableName}.rmsvar");
        }
    }
}
