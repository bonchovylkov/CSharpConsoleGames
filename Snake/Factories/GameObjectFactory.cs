using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Factories
{
    public abstract class GameObjectFactory
    {
        public abstract IGameObject Create(params IGameObject[] collideObject);
        
        public IGameObject SetRandomPositionedItem(GameObject gameObject, params IGameObject[] collideObject)
        {
            do
            {
                gameObject.Position = gameObject.CreateRandomPosition();
            }
            while (collideObject.Any(c => c.CollideWith(gameObject)));

            return gameObject;
        }
    }
}
