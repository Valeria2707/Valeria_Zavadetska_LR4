﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class ChristmasTree : IForestElement, IPlant
    {
        public void Plant() => Console.WriteLine("Ви посадили ялинку! ");
    }
}
