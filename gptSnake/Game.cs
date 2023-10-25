using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gptSnake
{
    internal class Game
    {
        private Random _rnd;
        public Game(int width, int height)
        {
            _rnd = new Random();
            Width = width;
            Height = height;
            Score = 5;
            GameSnake = new Snake(Score, new Pixel(Width/2, Height/2));
            IsLost = false;
            Console.WindowHeight = Height;
            Console.WindowWidth = Width;
        }

        public Snake GameSnake { get; private set; }

        public bool IsLost { get; private set; }
        public int Width { get; }
        public int Height { get; }

        public int Score { get; set; }

        public (int row, int col) GeneratePosition()
        {
            int row, col;
            do
            {
                row = _rnd.Next(0, Height - 1);
                col = _rnd.Next(0, Width - 1);
            } while (GameSnake.SnakeBody.Contains(new Pixel(col, row)));
                                
            return new (row, col);
        }



        public void GameLoop()
        {
            Console.CursorVisible = false;
            (int row, int col) = GeneratePosition();
            Berry berry = new Berry(row, col);
            GameSnake.SnakeDirection = Snake.Direction.Right;
            while (true)
            {
                Console.Clear();

                if(GameSnake.SnakeHead.xpos == Width - 1 || GameSnake.SnakeHead.xpos == 0 || GameSnake.SnakeHead.ypos == Height - 1 || GameSnake.SnakeHead.ypos == 0)
                {
                    IsLost = true;
                }

                if(GameSnake.SnakeHead.xpos == berry.Col && GameSnake.SnakeHead.ypos == berry.Row)
                {
                    Score++;
                    berry.WhenEaten(GameSnake);
                    (row, col) = GeneratePosition();
                    berry = new Berry(row, col);
                }

                GameSnake.Draw();
                GameSnake.UpdateTail();
                GameSnake.UpdateHead();
                berry.Place();

                
                Thread.Sleep(50);
                GameSnake.HandleMove();

                if(GameSnake.SnakeBody.Contains(GameSnake.SnakeHead))
                {
                    IsLost = true;
                }

                GameSnake.UpdateBody();
                if(IsLost) { break; }
            }

        }
    }
}
