using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace gptSnake
{
    internal class Snake
    {
        public Snake(int initialLength, Pixel startPosition)
        {
            SnakeBody = new List<Pixel>();
            SnakeLength = initialLength;
            SnakeHead = startPosition;
        }
        public Snake (){
            
        }

        public List<Pixel> SnakeBody { get; set; }
        public Pixel SnakeHead { get; set; }
        public int SnakeLength {  get; set; }

        public Direction SnakeDirection { get; set; }

        public void Draw()
        {
            for (int i = 0; i < SnakeBody.Count(); i++)
            {
                int x = SnakeBody[i].xpos;
                int y = SnakeBody[i].ypos;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("■");
            }
            Console.ResetColor();
        }

        public void UpdateTail()
        {
            if(SnakeBody.Count > SnakeLength)
            {
                SnakeBody.RemoveAt(0);
            }
        }

        public void UpdateHead() 
        {
            Console.SetCursorPosition(SnakeHead.xpos, SnakeHead.ypos);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("■");
        }

        public void UpdateBody()
        {
            SnakeBody.Add(SnakeHead);
        }

        public void HandleMove()
        {
            Pixel position = SnakeHead;
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo moveDirection = Console.ReadKey(true);
                if (moveDirection.Key.Equals(ConsoleKey.UpArrow) && SnakeDirection != Direction.Down)
                {
                    SnakeDirection = Direction.Up;
                }
                if (moveDirection.Key.Equals(ConsoleKey.DownArrow) && SnakeDirection != Direction.Up)
                {
                    SnakeDirection = Direction.Down;
                }
                if (moveDirection.Key.Equals(ConsoleKey.LeftArrow) && SnakeDirection != Direction.Right)
                {
                    SnakeDirection = Direction.Left;
                }
                if (moveDirection.Key.Equals(ConsoleKey.RightArrow) && SnakeDirection != Direction.Left)
                {
                    SnakeDirection = Direction.Right;
                }
            }
            if (SnakeDirection == Direction.Up) { position.ypos--; }
            if (SnakeDirection == Direction.Down) { position.ypos++; }
            if (SnakeDirection == Direction.Left) { position.xpos--; }
            if (SnakeDirection == Direction.Right) { position.xpos++; }
            SnakeHead = position;
        }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
    }
}
