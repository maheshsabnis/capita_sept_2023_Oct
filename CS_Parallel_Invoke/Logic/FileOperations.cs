using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_Parallel_Invoke.Logic
{
    internal class FileOperations
    {
        public string ReadJames()
        {
            string contents = String.Empty;
            using (StreamReader reader = new StreamReader(@"C:\Capita\Files\James.txt"))
            { 
              contents = reader.ReadToEnd();
            }
                return contents;
        }

        public string ReadEthan()
        {
            string contents = String.Empty;
            using (StreamReader reader = new StreamReader(@"C:\Capita\Files\Ethan.txt"))
            {
                contents = reader.ReadToEnd();
            }
            return contents;
        }

    }
}
