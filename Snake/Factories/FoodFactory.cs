using Snake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Factories
{
    public class FoodFactory : GameObjectFactory
    {
        public override IGameObject Create(params IGameObject[] collideObject)
        {
            Food food = new Food();
            SetRandomPositionedItem(food, collideObject);
            return food;
        }
    }
}
