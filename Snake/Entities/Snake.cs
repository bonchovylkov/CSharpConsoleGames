using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Entities
{
    public class Snake : CompositeGameObject
    {
        private SnakeHead sneakHead;

        public SnakeHead SnakeHead { 
            get 
            {
                if (this.sneakHead == null)
                {
                    this.sneakHead = new SnakeHead(this.Items.Last().Position);
                }

                return sneakHead;
            }
        }

        public Snake()
        {
            this.Items = new Queue<SnakeBody>();

            for (int i = 0; i <= 5; i++)
            {
                var snakeBodyItem = new SnakeBody(new Position(0, i));
                ((Queue<SnakeBody>)this.Items).Enqueue(snakeBodyItem);
            }
        }

        public void UpdateSnakeHead(Direction direction)
        {
            this.SnakeHead.SetHeadDisplay(direction);
        }
    }
}
