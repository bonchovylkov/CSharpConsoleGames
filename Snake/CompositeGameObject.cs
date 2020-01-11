using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class CompositeGameObject : IGameObject
    {
        public IEnumerable<GameObject> Items { get; set; }

        public bool CollideWith(IGameObject otherGameObject)
        {
            return Items.Any(i => otherGameObject.CollideWith(i));
        }

        public virtual void Draw()
        {
            foreach (GameObject item in Items)
            {
                item.Draw();
            }
        }
    }
}
