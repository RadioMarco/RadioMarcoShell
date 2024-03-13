using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class Splash
    {
        public static string ShowSplash() 
        {

        string[] splashes = { "Made With C-Sharp", "didn't contain Sudo", "was not polite.", "help help", "Made inefficently", "Designed for Windows",
            "sudidn't",  "Contains EasterEggs", "Violates many Coding Conventions", "No Comments",">_<","Don't be shy.", "Isn't not incosistent",
                "Hurry up!","Cucuc", "colorful","colourful","clrful","is indeed polite. now", "is relatable","sudoes", "does contain Sudo", };
            int splashNumber;
            Random ran = new Random();
            splashNumber = ran.Next(0, splashes.Length);


            return splashes[splashNumber];
        
        }

    }
}
