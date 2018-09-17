using System;
using System.Threading;

namespace FallenString
{
    class Program
    {
        static void Main()
        {
            Console.Title = " ";
            Console.CursorVisible = false;

            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.Clear();
                for (int i = 0; i < 100; i += 4)
                {
                    new Thread(new ParameterizedThreadStart(FallenString.Method)).Start(i);
                    Thread.Sleep(10);
                }
                for (int i = 2; i < 100; i += 4)
                {
                    new Thread(new ParameterizedThreadStart(FallenString.Method)).Start(i);
                    Thread.Sleep(40);
                }
            
        }
    }
}