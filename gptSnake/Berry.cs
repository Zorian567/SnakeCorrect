using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gptSnake
{
    internal class Berry : Bonus
    {

        public Berry(int row, int col)
        {
            Col = col;
            Row = row;
            BerryColor = ConsoleColor.Green;
        }

        public ConsoleColor BerryColor { get; init; }
        public int Col { get; set; }
        public int Row { get; set; }

        public override void Place()
        {
            Console.SetCursorPosition(Col, Row);
            Console.ForegroundColor = BerryColor;
            Console.Write("$");
            Console.ResetColor();
        }

        public override void WhenEaten(Snake snake)
        {
            snake.SnakeLength++;
        }

    }
}
