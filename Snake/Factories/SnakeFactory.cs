﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Factories
{
    public class SnakeFactory : GameObjectFactory
    {
        public override IGameObject Create(params IGameObject[] collideObject)
        {
            return new Snake.Entities.Snake();
        }
    }
}
