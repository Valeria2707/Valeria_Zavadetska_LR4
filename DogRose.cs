using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class DogRose : ICollectableForestElement
    {
        public void Pluck() => Console.WriteLine("Ви зібрали плоди на кущах ягоди шипшини! ");
    }
}
