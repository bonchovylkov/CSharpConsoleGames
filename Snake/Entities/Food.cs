using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Entities
{
    public class Food : GameObject
    {
        public Food()
        {
            Init();
        }

        public Food(Position position)
            : base(position)
        {
            Init();
        }


        public override void Init()
        {
            this.Color = ConsoleColor.Yellow;
            this.Display = GameDisplay.Food;
        }

        public void Disappear()
        {
            this.Display = GameDisplay.Empty;
            this.Draw();
        }
    }
}
