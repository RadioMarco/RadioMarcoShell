using System.Net.NetworkInformation;
namespace RMS2
{

    /// <summary>
    /// Für Titel und Metainformationen zu oberst in der Konsole
    /// </summary>
    internal class StartUp
    {
        public static void Title(string title = "#Radio Marco")
        {
            Console.Clear();
            ASCIIWriter.ASCIIWritingMachine(title);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Radio Marco Shell  version 2.0 //OS-Kernel: {Environment.OSVersion} // User: {Environment.UserName}@{Environment.UserDomainName} // Hostname: {Environment.MachineName}");
            Console.WriteLine(Network.getLocalIPAddressWithNetworkInterface(NetworkInterfaceType.Wireless80211));

            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Splash.ShowSplash());
                Console.ForegroundColor = Program.foregroundColor;
                Console.WriteLine();
                if (!OperatingSystem.IsWindows())
                {
                    Error.throwCustomError("You're using an OperatingSystem other than Windows. Some funktions may won't work properly and software crashes could accure.");
                }
            
        }
            public static void Commandli()
            {
            ASCIIWriter.ASCIIWritingMachine(">_<");
                Console.WriteLine("Commändli.");

            }
        }
    } 
