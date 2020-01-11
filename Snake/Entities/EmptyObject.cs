using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Entities
{
    public class EmptyObject : GameObject
    {
        public EmptyObject(Position position)
            : base(position)
        {
            this.Display = GameDisplay.Empty;
        }
    }
}
