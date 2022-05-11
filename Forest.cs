using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba4;

namespace laba4
{
    class Forest
    {
        List<IForestElement> trees = new List<IForestElement>();


        public void Plant(IForestElement tree)
        {
            trees.Add(tree);
        }

        public void CutDown(IForestElement tree)
        {
            trees.Remove(tree);
        }

        public int ElementsCount()
        {
            return trees.Count;
        }
    }
}
