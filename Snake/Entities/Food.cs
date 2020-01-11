﻿using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Entities
{
    public class Food : GameObject
    {
        public Food(Position position)
            : base(position)
        {
            this.Color = ConsoleColor.Yellow;
            this.Display = GameDisplay.Food;
        }
    }
}
