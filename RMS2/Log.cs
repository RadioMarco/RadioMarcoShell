namespace RMS2
{/// <summary>
/// Die <c>Log</c> Klasse ist hier, um einen String in die Logdatei zu Speicheren. Dies kann verschiedene Vorteile mit sich bringen
/// so kann man alle Fehler mit mehr Informationen und Datum und Uhrzeit in Sekunden durchlesen. Nicht im Log enthalten sind die erfolgreich ausgeführten Befehlen,
/// so wie die Befehlszeile eingabe allgemein. Letzteres wird in einer seperaten Datei gespeichert.
/// </summary>
    internal class Log
    {
        /// <summary>
        /// Die <c>Message</c>-Methode ist für alle nicht Fehler informationen (wie z.B. am Anfang oder ordinären Schluss einer Session oder mit dem Befehl <c>log</c> geschriebene
        /// informationen zuständig.
        /// </summary>
        /// <param name="message">Text welcher im Log angezeigt werden soll</param>
        public static void Message(string message)
        {
            string path = Environment.GetEnvironmentVariable("RMS2logs");
            string curdir = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(path);
            path += "\\log.rmsl";
            using StreamWriter swMessage = File.AppendText(path);
            if (message == "start")
            {
                
               swMessage.WriteLine($"[{DateTime.UtcNow} UTC]: session started as {Environment.UserName} on {Environment.MachineName}");
                
                Console.WriteLine($"[{DateTime.Now}]: session started as {Environment.UserName} on {Environment.MachineName}");
            }
           else if (message == "stop")
            {
                swMessage.WriteLine($"[{DateTime.UtcNow} UTC]: session ended as {Environment.UserName} on {Environment.MachineName}");
                
            }
            else
            {
                swMessage.WriteLine($"[{DateTime.UtcNow} UTC]: {message}");
            }
            swMessage.Dispose();
            Directory.SetCurrentDirectory(curdir);
        }
        public static void Command(string command)
        {
            string path = Environment.GetEnvironmentVariable("RMS2logs");
            string curdir = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(path);
            path += "\\commands.rmsl";
            using StreamWriter swCommand = File.AppendText($"{Environment.GetEnvironmentVariable("RMS2logs")}\\commands.rmsl");
            swCommand.WriteLine(command);
            swCommand.Dispose();
            Directory.SetCurrentDirectory(curdir);

        }
    }
}
