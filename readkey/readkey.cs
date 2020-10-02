using System;

namespace c_4
{
    class readkey
    {
        static void Main(string[] args)
        {
        Console.Write("Push any button");
        var key = Console.ReadKey();
        Console.WriteLine($"\nYou pressed {key}!");
        }
    }
}