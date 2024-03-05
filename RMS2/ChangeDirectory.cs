using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS2
{
    internal class ChangeDirectory
    {
       public static void SetPath(string path)
        {
            try
            {
                Directory.SetCurrentDirectory(path);
            }
            catch (UnauthorizedAccessException)
            {
                Error.throwUnautohrizedAccess(path);
            }
            catch (DirectoryNotFoundException)
            {
                Error.throwArgumentError("changedirectory", path);
            }
        }
        public static void MakeDirectory(string name)
        {
            try
            {
                Directory.CreateDirectory(name);
            }
            catch(DirectoryNotFoundException)
            {
                Error.throwCustomError("Something went wrong, this name is probably illegal or something.");
            }
            catch (UnauthorizedAccessException)
            {
                Error.throwUnautohrizedAccess(name);
            }
        }
        public static void RemoveDirectory(string name)
        {
            try
            {
                Directory.Delete(name);
            }
            catch (DirectoryNotFoundException)
            {
                Error.throwArgumentError("removedirectory", name);
            }
            catch (System.IO.IOException)
            {
                Error.throwCustomError("Windows refuses to delete Directories with Content in it. You might want to delete the contents of the Directory first.");
            }
        }

    }
}

