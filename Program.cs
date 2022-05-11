using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba4;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest();
            Bush bush = new Bush();
            Berries berries = new Berries();
            DogRose dogRose = new DogRose();
            ChristmasTree christmasTree = new ChristmasTree();
            Tree tree = new Tree();

            forest.Plant(bush);
            ((IPlant)bush).Plant();

            forest.Plant(tree);
            ((IPlant)tree).Plant();

            forest.Plant(christmasTree);
            ((IPlant)christmasTree).Plant();

            Console.WriteLine("У лiсi є " + forest.ElementsCount() + " дерев");

            forest.CutDown(tree);
            ((ICutDown)tree).CutDown();

            Console.WriteLine("У лiсi є  " + forest.ElementsCount() + " дерев");

            bush.Plant(berries);
            bush.Plant(dogRose);
            bush.Plant(berries);
            bush.Plant(berries);
            bush.Plant(berries);

            Console.WriteLine("Кущ має " + bush.ElCount() + " ягiд");

            bush.PickUp(berries);
            bush.PickUp(berries);
            bush.PickUp(berries);
            bush.PickUp(berries);
            bush.PickUp(dogRose);
            ((ICollectableForestElement)dogRose).Pluck();

            Console.WriteLine("Кущ має " + bush.ElCount() + " ягiд");




        }
    }
}