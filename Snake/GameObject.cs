using Snake.Enums;
using Snake.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GameObject : IGameObject
    {
        public GameObject(Position position)
        {
            this.Position = position;
        }

        public Position Position { get; set; }

        public GameDisplay Display { get; set; }

        public ConsoleColor? Color { get; set; }

        public bool CollideWith(IGameObject otherGameObject)
        {
            return  this.Position.Equals(otherGameObject);
        }

        public void Draw()
        {
            if (this.Color.HasValue)
            {
                Console.ForegroundColor = this.Color.Value;
            }

            Console.SetCursorPosition(this.Position.y, this.Position.x);
            Console.Write(this.Display);
        }
    }
}
