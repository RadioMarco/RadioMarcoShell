using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class StartUp
    {
        public static void Title()
        {
            Console.WriteLine("------#---RRRR---------A----------DDDDDD-----I------OOOOO--------MM------MM--------A--------RRRR-----CCCCC-----OOOOO---");
            Console.WriteLine("-----#----R--R--------A-A---------D-----D----I----O-------O------M-M----M-M-------A-A-------R--R----C--------O-------O-");
            Console.WriteLine("----#-----R--R-------A---A--------D------D---I---O---------O-----M--M--M--M------A---A------R--R---C--------O---------O");
            Console.WriteLine("######----R-R-------AAAAAAA-------D------D---I---O---------O-----M---MM---M-----AAAAAAA-----R-R----C--------O---------O");
            Console.WriteLine("#----#----RR-------A-------A------D------D---I---O---------O-----M--------M----A-------A----RR-----C--------O---------O");
            Console.WriteLine("##--##----R-R------A-------A------D-----D----I----O-------O------M--------M----A-------A----R-R-----C--------O-------O-");
            Console.WriteLine("######----R--R-----A-------A------DDDDDD-----I------OOOOOO-------M--------M----A-------A----R--R-----CCCCC-----OOOOO---");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Radio Marco Shell  version α 2.0.4 //OS-Kernel: {Environment.OSVersion} // User: {Environment.UserName}@{Environment.UserDomainName}");
            Console.WriteLine();
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
            Console.WriteLine(">               <");
            Console.WriteLine(" >             <");
            Console.WriteLine("  >           <");
            Console.WriteLine(" >             <");
            Console.WriteLine(">     _____     <");
            Console.WriteLine();
            Console.WriteLine("Commändli.");

        }
    }
}
