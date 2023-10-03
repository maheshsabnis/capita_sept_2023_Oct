using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;

namespace CS_TaskObject.Logic
{
    internal class FileOperations
    {
        public string ReadJames()
        {

            string contents = String.Empty;
            try
            {
                // Dummy Code to throw an exeption
                if (File.Exists(@"C:\Capita\Files\James.txt"))
                {
                    throw new Exception("File Exist");
                }

                using (StreamReader reader = new StreamReader(@"C:\Capita\Files\James.txt"))
                {
                    contents = reader.ReadToEnd();
                }
               
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error Occurred {ex.Message}");
                File.AppendAllText(@"C:\Capita\Files\myfile.txt" , ex.Message );
                throw ex;
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
