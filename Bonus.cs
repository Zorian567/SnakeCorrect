using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gptSnake
{
    internal abstract class Bonus
    {
        public abstract void WhenEaten(Snake snake);
        public abstract void Place();
    }
}
