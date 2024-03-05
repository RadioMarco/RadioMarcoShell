using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class Files
    {
        public static void WriteInFile(string[] text)
        {
            try
            {
                using StreamWriter sw = File.AppendText(text[1]);
                {
                    for (int i = 2;i < text.Length;i++)
                    {
                        if (text[i] == "/br")
                        {
                            sw.WriteLine();
                        }
                        else
                        {
                            sw.Write(text[i]);
                            sw.Write(" ");
                        }
                    }
                }
             
            }
            catch (FileNotFoundException)
            {
                Error.throwUnautohrizedAccess(text[1]);
            }
            catch (UnauthorizedAccessException)
            {
                Error.throwUnautohrizedAccess(text[1]);
            }
            catch (DirectoryNotFoundException)
            {
                Error.throwUnautohrizedAccess(text[1]);
            }
        }
        public static void RemoveFile(string file)
        {
            try
            {


                File.Delete(file);
            }
            catch (IOException)
            {
                Error.throwUnautohrizedAccess(file);
            }
            catch (UnauthorizedAccessException)
            {
                Error.throwUnautohrizedAccess(file);
            }
        }
        public static void MoveFile(string file, string destination, string isInChildFolderStr = "true")
        {
            destination = destination + "\\" + file;
            if (isInChildFolderStr == "true")
            {
                destination = Directory.GetCurrentDirectory() + "\\" + destination;

            }

            try
            {
                File.Move(file, destination, true);
            }
            catch (System.IO.FileNotFoundException)
            {
                Error.throwUnautohrizedAccess(file);
            }



        }
    }
}
