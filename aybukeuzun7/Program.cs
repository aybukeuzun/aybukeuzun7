using System.Runtime.InteropServices;

string hello = "Hello, world!";
string panic = "Don't panic!";

PrintStringFiveTimes(hello);
PrintStringFiveTimes(panic);
PrintStringFiveTimes("aybuke");

static void PrintStringFiveTimes(string someString)
{
    for (int i = 0; i < 5; i++)
    {
        Console.Write(someString);
    }
}