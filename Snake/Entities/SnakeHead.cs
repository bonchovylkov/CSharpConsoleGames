using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Entities
{
    public class SnakeHead : GameObject
    {
        public SnakeHead(Position position) 
            : base(position)
        {
            this.Display = GameDisplay.SnakeHeadRight;
            this.Color = ConsoleColor.Gray;
        }

        public void SetHeadDisplay(Direction direction)
        {
            var headSymbol = GameDisplay.SnakeHeadRight;

            if (direction == Direction.Left) headSymbol = GameDisplay.SnakeHeadLeft;
            if (direction == Direction.Up) headSymbol = GameDisplay.SnakeHeadUp;
            if (direction == Direction.Down) headSymbol = GameDisplay.SnakeHeadDown;
        }
    }
}
