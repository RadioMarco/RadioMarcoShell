﻿namespace RMS2
{
    internal class Wait
    {
        public static void waitInterpret(string[] command)
        {
            int waitingTime;
            if (command.Length < 2)
            {
                waitingTime = 100;
            }
            else
            {
                waitingTime = StringTools.StringToInt(command[1]);
            }

            Thread.Sleep(waitingTime);
            if (waitingTime == 6502 && command.Length > 2)
            {
                int repeatSplash;
                string textSplash = "RADIOMARCO!";
                repeatSplash = StringTools.StringToInt(command[2]);
                if (command.Length > 3)
                {
                    textSplash = StringTools.StringResasembler(command, 3).ToUpper();
                }
                for (int i = 0; i < repeatSplash; i++)
                {
                    Console.Write(textSplash);
                }

            }
        }
    }
}
