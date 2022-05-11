using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Bush : ICollectableForestElement, IPlant
    {
        public void Plant() => Console.WriteLine("Кущ посаджано! ");

        List<ICollectableForestElement> berry = new List<ICollectableForestElement>();
        public void Plant(ICollectableForestElement berries)
        {
            berry.Add(berries);
        }

        public void PickUp(ICollectableForestElement berries)
        {
            berry.Remove(berries);
        }
        public int ElCount()
        {
            return berry.Count;
        }
        public void Pluck()
        {
            throw new NotImplementedException();
        }

        public void PutIn()
        {
            throw new NotImplementedException();
        }
    }
}
