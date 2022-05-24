using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    //Om alla djur behöver ett nytt attribut bör vi lägga det här (I klassen Animal)
    public abstract class Animal
    {
        public string Name { set; get; }
        public double Weight { set; get; }
        public uint Age { set; get; }

        public Animal(string name, double weight, uint age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        public virtual string Stats() 
        {
            string strOut = string.Format("Animal: Name: {0, -7}, Weight: {1, -4}, Age: {2, -3} years",
                Name, Weight, Age);
            return strOut;
        }
    }

    class Horse:Animal
    {
        public double Height { set; get; }

        public Horse(double height, string name, double weight, uint age) : base(name, weight, age) 
        {
            Height = height;
        }

        public override void DoSound()
        {
            Console.WriteLine("Horse's Sound: Heee heee heee!");
        }

        public override string Stats()
        {
            string strOut = string.Format("Horse: Height: {0, -4} Name: {1, -7}, Weight: {2, -4}, Age: {3, -3} years",
                Height, Name, Weight, Age);
            return strOut;
        }
    }

    class Dog : Animal
    {
        public string Type { set; get; }

        public Dog(string type, string name, double weight, uint age) : base(name, weight, age)
        {
            Type = type;
        }

        public override void DoSound()
        {
            Console.WriteLine("Dog's Sound: Hawoo hawoo hawoo!");
        }

        public void SpecialMethod()
        {
            Console.WriteLine("This is dog's special method");
        }

        public override string Stats()
        {
            string strOut = string.Format("Dog: Type: {0, -4} Name: {1, -7}, Weight: {2, -4}, Age: {3, -3} years",
                Type, Name, Weight, Age);
            return strOut;
        }
    }

    class Hedgehog : Animal
    {
        public uint NrOfSpikes { set; get; }

        public Hedgehog(uint nrOfSpikes, string name, double weight, uint age) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog's Sound: Hevv hevv hevv!");
        }

        public override string Stats()
        {
            string strOut = string.Format("Hedgehog: NrOfSpikes: {0, -4} Name: {1, -7}, Weight: {2, -4}, Age: {3, -3} years",
                NrOfSpikes, Name, Weight, Age);
            return strOut;
        }
    }

    class Worm : Animal
    {
        public bool IsPoisonous { set; get; }

        public Worm(bool isPoisonous, string name, double weight, uint age) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm's Sound: Wriggling Wriggling Wriggling!");
        }

        public override string Stats()
        {
            string strOut = string.Format("Worm: IsPoisonous: {0, -4} Name: {1, -7}, Weight: {2, -4}, Age: {3, -3} years",
                IsPoisonous, Name, Weight, Age);
            return strOut;
        }

    }

    //Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
    //attribut, bör vi lägga det här (I klassen Bird)
    class Bird : Animal
    {
        public double WingSpan { set; get; }

        public Bird(double wingSpan, string name, double weight, uint age) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bird's Sound: Cuckoo cuckoo cuckoo!");
        }
        public override string Stats()
        {
            string strOut = string.Format("Bird: WingSpan: {0, -4} Name: {1, -7}, Weight: {2, -4}, Age: {3, -3} years",
                WingSpan, Name, Weight, Age);
            return strOut;
        }
    }

    class Wolf : Animal
    {
        public string Color { set; get; }

        public Wolf(string color, string name, double weight, uint age) : base(name, weight, age)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf's sound: Woof woof woof!");
        }
        public override string Stats()
        {
            string strOut = string.Format("Wolf: Color: {0, -7}, Name: {1, -7}, Weight: {2, -4}, Age: {3, -3} years",
                Color, Name, Weight.ToString(), Age.ToString());
            return strOut;
        }
    }
}
