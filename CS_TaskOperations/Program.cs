// See https://aka.ms/new-console-template for more information
using CS_TaskOperations.Logic;

Console.WriteLine("DEMO Standrad .NET Methods with Task");
//FileOperations file = new FileOperations();
//string fileName = @"C:\Capita\Files\myfile.txt";
//var result = file.CreateFile(fileName);
//if (result)
//{
//    file.WriteFile(fileName,"I am the File");
//    Console.WriteLine("Something on Main Thread");
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Some Other Logic: {i}");
//    }
//}
//else
//{
//    Console.WriteLine("File Creation failed ");
//}

string fileNameasync = @"C:\Capita\Files\myfileasync.txt";

AsyncFileOperations asyncFileOperations = new AsyncFileOperations();

var res = asyncFileOperations.CreateFile(fileNameasync);

if (res)
{
    await asyncFileOperations.WriteFileAsync(fileNameasync, "Data is Written Asynchronously");

    var contents = await asyncFileOperations.ReadFileAsync(@"C:\Capita\Files\myfile.txt");

    Console.WriteLine($"File Contents : {contents}");

    Console.WriteLine("Some Other Operations on Main Thread");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"On Main THread i = {i}");
    }
}
else
{
    Console.WriteLine("File Creation Faled");
}



Console.ReadLine();
