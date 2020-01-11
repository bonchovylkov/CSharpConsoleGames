using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Entities
{
    public class ObstacleSet : CompositeGameObject
    {
        public ObstacleSet()
        {
            this.Items = new List<Obstacle>()
            {
                new Obstacle(new Position(12, 12)),
                new Obstacle(new Position(7, 7)),
                new Obstacle(new Position(19, 19)),
                new Obstacle(new Position(6, 9)),
                new Obstacle(new Position(14, 20))
            };
        }

        public void AddObstacle(GameObject obstacle)
        {
            this.Items.ToList().Add(obstacle);
        }
    }
}
