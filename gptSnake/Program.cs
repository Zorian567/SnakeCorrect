using gptSnake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //class Game
        //Console.WindowHeight = 24;
        //Console.WindowWidth = 50;
        //int screenwidth = Console.WindowWidth;
        //int screenheight = Console.WindowHeight;

        //Random randomnummer = new Random();
        //int score = 5;
        //Pixel head = new Pixel();
        //head.xpos = screenwidth / 2;
        //head.ypos = screenheight / 2;
        //string movement = "RIGHT";
        //List<int> xposlijf = new List<int>();
        //List<int> yposlijf = new List<int>();

        //int berryx = randomnummer.Next(1, screenwidth);
        //int berryy = randomnummer.Next(1, screenheight);

        //bool dood = false;
        //while (true)
        //{
        //    Console.Clear();
        //    if (head.xpos == screenwidth - 1 || head.xpos == 0 || head.ypos == screenheight - 1 || head.ypos == 0)
        //    {
        //        dood = true;
        //    }

        //    if (head.xpos == berryx && head.ypos == berryy)
        //    {
        //        score++;
        //        berryx = randomnummer.Next(1, screenwidth - 1);
        //        berryy = randomnummer.Next(1, screenheight - 1);
        //    }
        //    for (int i = 0; i < xposlijf.Count(); i++)
        //    {
        //        int x = xposlijf[i];
        //        int y = yposlijf[i];
        //        Console.SetCursorPosition(x, y);
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.Write("■");
        //    }
        //    if (xposlijf.Count() > score)
        //    {
        //        xposlijf.RemoveAt(0);
        //        yposlijf.RemoveAt(0);
        //    }
        //    Console.SetCursorPosition(head.xpos, head.ypos);
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.Write("■");
        //    Console.SetCursorPosition(berryx, berryy);
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.Write("■");
        //    DateTime tijd = DateTime.Now;
        //    while (true)
        //    {
        //        DateTime tijd2 = DateTime.Now;
        //        if (tijd2.Subtract(tijd).TotalMilliseconds > 100) { break; }
        //    }
        //    if (Console.KeyAvailable)
        //    {
        //        ConsoleKeyInfo toets = Console.ReadKey(true);
        //        if (toets.Key.Equals(ConsoleKey.UpArrow) && movement != "DOWN")
        //        {
        //            movement = "UP";
        //        }
        //        if (toets.Key.Equals(ConsoleKey.DownArrow) && movement != "UP")
        //        {
        //            movement = "DOWN";
        //        }
        //        if (toets.Key.Equals(ConsoleKey.LeftArrow) && movement != "RIGHT")
        //        {
        //            movement = "LEFT";
        //        }
        //        if (toets.Key.Equals(ConsoleKey.RightArrow) && movement != "LEFT")
        //        {
        //            movement = "RIGHT";
        //        }
        //    }
        //    if (movement == "UP") { head.ypos--; }
        //    if (movement == "DOWN") { head.ypos++; }
        //    if (movement == "LEFT") { head.xpos--; }
        //    if (movement == "RIGHT") { head.xpos++; }

        //    for (int i = 0; i < xposlijf.Count(); i++)
        //    {
        //        if (head.xpos == xposlijf[i] && head.ypos == yposlijf[i])
        //        {
        //            dood = true;
        //        }
        //    }

        //    xposlijf.Add(head.xpos);
        //    yposlijf.Add(head.ypos);
        //    if (dood)
        //    {
        //        break;
        //    }
        //}
        //Console.SetCursorPosition(screenwidth / 5, screenheight / 2);
        //Console.WriteLine("Game over, Score: " + score);
        //Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);

        Game newGame = new Game(50, 36);
        newGame.GameLoop();
    }

   
}
