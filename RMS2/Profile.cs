namespace RMS2
{
    public class Profile
    {
        private string? InitialPath;
        private ConsoleColor FontColor;
        private ConsoleColor BackgroundColor;
        private string? LogPath;

     

        /// <summary>
        /// User Profil, welches die Konfiguration wie der Dateipfad, die Hinter- und Vordergrund Farbe der Konsole und der Pfad der Log-Dateien speichert.
        /// </summary>
        /// <param name="inititalPath">Standardpfad der Applikation</param>
        /// <param name="fontColor">Schriftfarbe in der Konsole</param>
        /// <param name="backgroundColor">Hintergrundfarbe der Konsole</param>
        /// <param name="logPath">Pfad der Logs.</param>
        public Profile(string inititalPath,ConsoleColor fontColor,ConsoleColor backgroundColor,string logPath )
        {
            InitialPath = inititalPath;
           FontColor = fontColor;
            BackgroundColor = backgroundColor;
            LogPath = logPath;
            Log.Message("Profil erstellt");
        }

        public string? InitialPath1 { get => InitialPath; set => InitialPath = value; }
        public ConsoleColor FontColor1 { get => FontColor; set => FontColor = value; }
        public ConsoleColor BackgroundColor1 { get => BackgroundColor; set => BackgroundColor = value; }
        public string? LogPath1 { get => LogPath; set => LogPath = value; }
    }
}
