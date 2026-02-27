namespace  Task1;

using System;

class Program
{
    static void Main(string [ ] args)
    {
        ShowEnvironment.GetInfo();
        var vas = Console.Read();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(vas);
        

    }
}