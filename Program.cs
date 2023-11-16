using gptSnake;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------MAIN MENU--------------------");
        Console.WriteLine("-----------------Select an option:---------------");
        Console.WriteLine("---------------------1. PLAY---------------------");
        Console.WriteLine("---------------------2. EXIT---------------------");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Game newGame = new Game(50, 36);
                newGame.GameLoop();
                break;
            case 2:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
