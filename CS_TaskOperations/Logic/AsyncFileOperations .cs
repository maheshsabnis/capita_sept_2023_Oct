using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CS_TaskOperations.Logic
{
    internal class AsyncFileOperations
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
        /// <summary>
        /// Async Write Method
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="contents"></param>
        /// <returns></returns>
        public async Task<bool> WriteFileAsync(string fileName, string contents)
        {
            await Console.Out.WriteLineAsync("In Write Method Start");
            if (!File.Exists(fileName))
                return false;
            //Thread.Sleep(5000); // Sleep for 5 Seconds
              await File.WriteAllTextAsync(fileName, contents);
            await Console.Out.WriteLineAsync("In Write Method End");
            return true;
        }
        /// <summary>
        /// Async Read Method
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public async Task<string> ReadFileAsync(string fileName)
        {
            await Console.Out.WriteLineAsync("In Read Method Start");
            if (!File.Exists(fileName))
                return "File Not Found";
          //  Thread.Sleep(5000); // Sleep for 5 Seconds
            string contents = await File.ReadAllTextAsync(fileName);
           
            await Console.Out.WriteLineAsync("In Read Method End");
            return contents;
        }
    }
}
