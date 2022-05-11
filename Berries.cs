using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Berries : ICollectableForestElement
    {
        public void Pluck() => Console.WriteLine("Ви зiрвали ягоди ");
    }
}
