using System;

namespace FallenString
{
    static class FallenString
    {
        static char[] Chinese = new char[] {'Q','W','E','R','T','Y','U','I','O','P','A','S','D','F','G',
                                           'H','J','K','L','Z','X','C','V','B','N','M','1','2','3','4',
                                           '5','6','7','8','9','0','Й','Ц','У','К','Е','Н','Г','Ш','Щ',
                                           'З','Х','Ъ','Ф','Ы','В','А','П','Р','О','Л','Д','Ж','Э','Я',
                                           'Ч','С','М','И','Т','Ь','Б','Ю','№','@','#','%','$','&','?'
                                            ,'-','=','\''};
        static object locker = new object();
        static int ChLength = Chinese.Length - 1;
        static Random rand = new Random();

        public static void Method(object x)
        {
            int maxlength = 29;
            int stringheight = rand.Next(12, 20);
            int posx = (int)x;
            int posy = rand.Next(0, 10);
            int current = posy;

            for (; ; )
            {
                lock (locker)
                {
                    if (current == posy)
                    {
                        Console.SetCursorPosition(posx, current);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(Chinese[rand.Next(0, ChLength)]);
                        current++;
                    }
                    else if (current == posy + 1)
                    {
                        Console.SetCursorPosition(posx, current);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(Chinese[rand.Next(0, ChLength)]);
                        Console.SetCursorPosition(posx, current - 1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Chinese[rand.Next(0, ChLength)]);
                        current++;
                    }
                    else if (current > posy + 1)
                    {
                        if (current < maxlength)
                        {

                            if (current - posy >= stringheight)
                            {
                                Console.SetCursorPosition(posx, current - stringheight);
                                Console.WriteLine(" ");
                            }
                            Console.SetCursorPosition(posx, current);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(Chinese[rand.Next(0, ChLength)]);
                            Console.SetCursorPosition(posx, current - 1);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(Chinese[rand.Next(0, ChLength)]);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.SetCursorPosition(posx, current - 2);
                            Console.WriteLine(Chinese[rand.Next(0, ChLength)]);
                            current++;
                        }
                        else
                        {
                            for (int i = 0; i < maxlength; i++)
                            {
                                Console.SetCursorPosition(posx, i);
                                Console.WriteLine(" ");
                                current = posy;
                            }
                        }

                    }
                }
            }
        }
    }
}