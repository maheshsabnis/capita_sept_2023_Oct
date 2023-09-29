using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CS_TaskOperations.Logic
{
    internal class FileOperations
    {
        public bool CreateFile(string fileName)
        { 
            if(File.Exists(fileName))
                return false;

            FileStream fs = File.Create(fileName);
            // Closign The File
            fs.Close();
            return true;
        }

        public bool DeleteFile(string fileName) 
        {
            if (!File.Exists(fileName))
                return false;
            File.Delete(fileName);
            return true;
        }

        public bool WriteFile(string fileName, string contents)
        {
            if (!File.Exists(fileName))
                return false;
            Thread.Sleep(5000); // Sleep for 5 Seconds
            File.WriteAllText(fileName, contents);
            return true;
        }

        public string ReadFile(string fileName)
        {
            if (!File.Exists(fileName))
                return "File Not Found";
         //   Thread.Sleep(5000); // Sleep for 5 Seconds
            string contents = File.ReadAllText(fileName);
            return contents;
        }
    }
}
