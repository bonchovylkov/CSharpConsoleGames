using Snake.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public abstract class GameObject : IGameObject
    {
        public Position Position { get; set; }

        public GameDisplay Display { get; set; }

        public bool CollideWith(IGameObject otherGameObject)
        {
            return this.Position.Equals(otherGameObject.Position);
        }
    }
}
