using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba4;

namespace laba4
{
    class Tree : IForestElement, ICutDown, IPlant
    {
        public void Plant() => Console.WriteLine("Дерево посаджано! ");
        public void CutDown() => Console.WriteLine("Упссс... Ви зрубали дерево! ");
    }
}
