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

        public Snake()
        {
            this.Items = new Queue<GameObject>();

            for (int i = 0; i <= 5; i++)
            {
                var snakeBodyItem = new SnakeBody(new Position(0, i));
                ((Queue<GameObject>)this.Items).Enqueue(snakeBodyItem);
            }
        }

        public void UpdateSnakeHeadDisplay(Direction direction)
        {
            this.sneakHead.SetHeadDisplay(direction);
        }

        public SnakeHead CalculateNewSnakeHead(Position nextDirection)
        {
            var head = this.Items.Last();
            var position = new Position(head.Position.x + nextDirection.x, head.Position.y + nextDirection.y);
            SnakeHead snakeNewHead = new SnakeHead(position);

            var finalPosition = snakeNewHead.Position;

            if (snakeNewHead.Position.y < 0) finalPosition.y = Console.WindowWidth - 1;
            if (snakeNewHead.Position.x < 0) finalPosition.x = Console.WindowHeight - 1;
            if (snakeNewHead.Position.x >= Console.WindowHeight) finalPosition.x = 0;
            if (snakeNewHead.Position.y >= Console.WindowWidth) finalPosition.y = 0;

            snakeNewHead.Position = finalPosition;

            return snakeNewHead;
        }

        public void UpdateHead(SnakeHead snakeHead)
        {
            this.sneakHead = snakeHead;
            this.Items.Last().Display = GameDisplay.SnakeBody;
            ((Queue<GameObject>)this.Items).Enqueue(snakeHead);

        }

        public override void Draw()
        {
            base.Draw();

            if (this.sneakHead != null)
            {
                this.sneakHead.Draw();
            }
        }


        public void Move()
        {
            var removedItem = ((Queue<GameObject>)this.Items).Dequeue();
            removedItem.Display = GameDisplay.Empty;
            removedItem.Draw();
        }
    }
}
