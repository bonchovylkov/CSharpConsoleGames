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
        public Obstacle()
        {
            this.Init();
        }

        public Obstacle(Position position) 
            : base(position)
        {
            this.Init();
        }

        public override void Init()
        {
            this.Color = ConsoleColor.Yellow;
            this.Display = GameDisplay.Obstacle;
        }
    }
}
