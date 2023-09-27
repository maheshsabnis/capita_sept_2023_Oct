// See https://aka.ms/new-console-template for more information
using CS_SealedClass;

Console.WriteLine("DEMO Sealed Class");
StringUtilities util = new StringUtilities();
string str = "C# is great";

Console.WriteLine($"Length of {str} is = {util.GetLength(str)}");
Console.WriteLine($"Upper Case of {str} is = {util.ChangeCase(str, 'U')}");
Console.WriteLine($"Lower case of {str} is = {util.ChangeCase(str, 'l')}");

string reverse = util.ReverseExt( str );
Console.WriteLine($"Reverse of {str} is = {reverse}");

int whiteSpaceCount = str.GetWhiteSpaceCount();

Console.WriteLine($"Counte of White Spaces in {str} is = {whiteSpaceCount}");

Console.ReadLine();
