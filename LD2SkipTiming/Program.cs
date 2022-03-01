using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static string displayString = "";
        static string choice;
        static int displayFrames = 45;
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start");
            choice = Console.ReadLine();
            for (int i = 0; i < displayFrames; i++)
            {
                displayString += "_";
            }
            Console.Clear();
            Console.Write(displayString);
            while (true)
            {
                if (choice == "")
                    saveTiming();
                else
                    menuTiming();
            }

            /*
            
            for (int i = 0; i < 100; ++i)
            {
                Console.Write("\r{0}%   ", i);
                Thread.Sleep(50);
            }
            Console.ReadLine();
            

            int msDelay = 60;
            int frames = 30;

            Console.Write(displayString);
            for (int i = msDelay; i > 0; i--)
            {
                Console.Clear();
                if (i - displayFrames < 0)
                {
                    displayString = displayString.Insert(i, "*");
                    displayString = displayString.Remove(0, 1);
                }
                Console.Write(displayString);
                Thread.Sleep(33);
                displayString = displayString.Replace("*", "_");
            }
            Console.ReadLine();*/
        }

        public static void saveTiming()
        {
            Console.CursorVisible = false;
            int initialDelay = 1583;
            int correctFrame = 24;
            Star.x = correctFrame;
            Star.drawStar();
            Thread.Sleep(initialDelay);
            while (Star.x > -3)
            {
                Star.drawStar();
                Thread.Sleep(1000 / 61);
            }
            inputWait();
        }

        public static void menuTiming()
        {
            Console.CursorVisible = false;
            int correctFrame = 16;
            Star.x = correctFrame;
            Star.drawStar();
            while (Star.x > -3)
            {
                Star.drawStar();
                Thread.Sleep(1000 / 61);
            }
            inputWait();
        }

        public static void inputWait()
        {
            Console.SetCursorPosition(0, 1);
            Console.CursorVisible = true;
            Console.Write("Press enter to start");
            choice = Console.ReadLine();
            Console.Clear();
            Console.Write(displayString);
        }

    }

    class Star
    {
        public static int x = 0;
        public static int y = 0;
        public static void drawStar()
        {
            if (x < -1)
            {
                x--;
                Console.SetCursorPosition(0, 0);
                Console.Write("_");
                Console.SetCursorPosition(1, 0);
                Console.Write("_");
                return;
            }
            if (x > 90 || x < -1)
            {
                x--;
                return;
            }
            Console.SetCursorPosition(x + 2, 0);
            Console.Write("_");
            if (x >= 0)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("*");
            }
            Console.SetCursorPosition(x + 1, 0);
            Console.Write("*");
            x--;
        }
    }
}