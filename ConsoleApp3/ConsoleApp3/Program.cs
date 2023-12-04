using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(10, 10);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            //Make maze
            Console.WriteLine("");
            Console.WriteLine(" \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 ");
            Console.WriteLine(" \u2588\u0020\u0020\u0020\u0020\u0020\u0020\u2588 ");
            Console.WriteLine(" \u2588\u0020\u2588\u2588\u2588\u2588\u0020\u2588 ");
            Console.WriteLine(" \u2588\u0020\u2588\u0020\u0020\u0020\u0020\u2588 ");
            Console.WriteLine(" \u2588\u0020\u2588\u0020\u2588\u2588\u2588\u2588 ");
            Console.WriteLine(" \u2588\u0020\u2588\u0020\u0020\u0020\u0020\u2588 ");
            Console.WriteLine(" \u2588\u0020\u2588\u2588\u2588\u2588\u0020\u2588 ");
            Console.WriteLine(" \u2588\u0020\u0020\u0020\u0020\u0020\u0020\u2588 ");
            Console.WriteLine(" \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 ");
            Console.Write("");

            int col = 7;
            int row = 6;
            Console.SetCursorPosition(col, row);
            Console.Write("*");
            Console.SetCursorPosition(col, row);
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.W)
                {
                    Console.Write(" ");
                    Debug.Print("W");
                    row--;
                }
                if (info.Key == ConsoleKey.Z)
                {
                    Console.Write(" ");
                    Debug.Print("Z");
                    row++;
                }

                if (info.Key == ConsoleKey.A)
                {
                    Console.Write(" ");
                    Debug.Print("A");
                    col--;
                }

                if (info.Key == ConsoleKey.S)
                {
                    Console.Write(" ");
                    Debug.Print("S");
                    col++;
                }

                Console.SetCursorPosition(col, row);
                Console.Write("*");
                Console.SetCursorPosition(col, row);

            }
        }
    }
}