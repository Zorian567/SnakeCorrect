﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gptSnake
{
    public struct Pixel
    {
        public int xpos { get; set; } 
        public int ypos { get; set; }
        public Pixel(int x, int y)
        {
            xpos = x;
            ypos = y;
        }
        //public ConsoleColor pixelColor { get; set; }


        //Game game = new Game(25, 16);
        //game.GameLoop();
    }
}
