using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Factories
{
    public class GameObjectFactoryProvider
    {
        private readonly Dictionary<GameItems, GameObjectFactory> factories;

        private GameObjectFactoryProvider()
        {
            factories = new Dictionary<GameItems, GameObjectFactory>
            {
                { GameItems.Snake, new SnakeFactory() },
                { GameItems.Food, new FoodFactory() },
                { GameItems.ObstacleSet, new ObstacleSetFactory() },
                { GameItems.Obstacle, new ObstacleFactory() },
                //{ GameItems.EmptySpace, new ObstacleSetFactory() },

                
            };

        }

        public static GameObjectFactoryProvider InitializeFactories() => new GameObjectFactoryProvider();

        public IGameObject ExecuteCreation(GameItems item, params IGameObject[] collideObject)
        {
            return factories[item].Create(collideObject);
        }
    }
}
