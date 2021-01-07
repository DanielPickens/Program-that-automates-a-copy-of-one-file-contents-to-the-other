using System;
using System.IO;
class Program
{
    static void Main()
    {
        File.Copy("sri.txt", "srip.txt");
        Console.WriteLine(File.ReadAllText("sri.txt"));
        Console.WriteLine(File.ReadAllText("srip.txt"));
        Console.Read();
    }
}
