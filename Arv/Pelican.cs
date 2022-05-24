using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Pelican : Bird
    {
        double Length { get; set; }
        public Pelican(double length, double wingSpan, string name, double weight, uint age) : base(wingSpan, name, weight, age)
        {
            Length = length;
        }

        public override void DoSound()
        {
            Console.WriteLine("Pelican's sound is: Squawk squawk squawk!");
        }

        public override string ToString()
        {
            string strOut = string.Format("Pelican: Length: {0, -4}, WingSpan: {1, -4},  Name: {2, -7}, Weight: {3, -4}, Age: {4, -2} years",
                Length, WingSpan, Name, Weight, Age);
            return strOut;
        }

    }
}
