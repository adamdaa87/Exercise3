using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    internal abstract class Vehicle
    {
        public abstract void Go();

    }
    class Car: Vehicle
    {
        public override void Go() 
        {
            Console.WriteLine("The car is moving!");
        }
        
    }

    class Bicycle: Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is rolling!");
        }

    }

    class Boat: Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is sailing!");
        }
    }

}
