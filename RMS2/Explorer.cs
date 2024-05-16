namespace RMS2
{
    /// <summary>
    /// Werkzeuge, zum bearbeiten und Einsehen von Ordnern 
    /// </summary>
    internal class Explorer
    {
       public static void SetPath(string path)
        {
            try
            {
                path = Variables.GetDefaultVariables(path);
                Directory.SetCurrentDirectory(path);
            }
            catch (UnauthorizedAccessException)
            {
                Error.throwUnautohrizedAccess(path);
            }
            catch (System.IO.IOException)
            {
                Error.throwArgumentError("changedirectory", path);
            }

        }
        public static void MakeDirectory(string name, bool init = false)
        {
            try
            {
                if (!init)
                {
                    name = Variables.GetDefaultVariables(name);
                }
                Directory.CreateDirectory(name);
            }
            catch(DirectoryNotFoundException)
            {
                if (init)
                    Error.throwCustomError("Something went wrong, this name is probably illegal or something.",true);
                else
                    Error.throwCustomError("Something went wrong, this name is probably illegal or something.");
            }
            catch (UnauthorizedAccessException)
            {
                Error.throwUnautohrizedAccess(name);
            }
        }
        public static void RemoveDirectoryOrFile(string name,bool recursive = false,bool hideInfos = false)
        {
            try
            {
                name = Variables.GetDefaultVariables(name);
                if (Directory.Exists(name))
                {
                    Directory.Delete(name, recursive);

                }
                else if (File.Exists(name))
                {
                    Files.RemoveFile(name);
                }
                else 
                {
                    if (!hideInfos)
                        Error.throwCustomError($"{name} does not exist.");  
                }
            }
            
            catch (System.IO.IOException)
            {
                if (!hideInfos)
                    Error.throwCustomError($"Couldn't delete this directory because it has content in it. try rm -r {name}");
            }
        }
        public static void ListAll(string directory)
        {
            Console.WriteLine();
            try
            {
                string[] file = Directory.GetFiles(directory);
                string[] dirs = Directory.GetDirectories(directory);
                Console.WriteLine("Subdirectories:");
                if (dirs.Length < 1)
                    Console.WriteLine("No Subdirectories");
                for (int i = 0; i < dirs.Length; i++)
                {
                    string[] longPath = dirs[i].Split('\\');
                    dirs[i] = longPath[longPath.Length - 1];
                    if (i % 2 == 0 || i == 0)
                    {
                        if (Program.foregroundColor != ConsoleColor.Gray)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = Program.foregroundColor;
                    }
                    Console.Write($"{dirs[i]} ");
                }
                Console.WriteLine();
                Console.WriteLine("Files:");
                if (file.Length < 1)
                    Console.WriteLine("No Files");
                for (int i = 0; i < file.Length; i++)
                {
                    string[] longPath = file[i].Split('\\');
                    file[i] = longPath[longPath.Length - 1];
                    if (i % 2 == 0 || i == 0)
                    {
                        if (Program.foregroundColor != ConsoleColor.Gray)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = Program.foregroundColor;
                    }
                    Console.Write($"{file[i]} ");
                }
                Console.ForegroundColor = Program.foregroundColor;
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (UnauthorizedAccessException)
            {
                Error.throwUnautohrizedAccess(Directory.GetCurrentDirectory());
            }
        }

    }
}

