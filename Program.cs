using System;

namespace ConsoleTaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Storage.Load();
            Comand.Recognize();
        }
    }
}
