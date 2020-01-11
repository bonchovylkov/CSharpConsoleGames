using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Entities
{
    public class Obstacle : GameObject
    {
        public Obstacle(Position position) 
            : base(position)
        {
            this.Color = ConsoleColor.Cyan;
            this.Display = GameDisplay.Obstacle;
        }
    }
}
