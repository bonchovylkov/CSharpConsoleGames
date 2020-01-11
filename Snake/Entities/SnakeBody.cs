using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Entities
{
    public class SnakeBody : GameObject
    {
        public SnakeBody(Position position) 
            : base(position)
        {
            this.Display = GameDisplay.SnakeBody;
            this.Color = ConsoleColor.Gray;
        }
    }
}
