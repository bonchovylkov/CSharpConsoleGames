using Snake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Factories
{
    public class ObstacleSetFactory : GameObjectFactory
    {
        public override IGameObject Create(params IGameObject[] collideObject)
        {
            return new ObstacleSet();
        }
    }
}
