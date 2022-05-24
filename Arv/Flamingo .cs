using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Flamingo : Bird
    {
        double LegsLength { get; set; }
        public Flamingo(double legsLength, double wingSpan, string name, double weight, uint age) : base(wingSpan, name, weight, age)
        {
            LegsLength = legsLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("Flamingo's sound is: Grunt grunt grunt!");
        }

        public override string ToString()
        {
            string strOut = string.Format("Flamingo: LegsLength: {0, -4}, WingSpan: {1, -4},  Name: {2, -7}, Weight: {3, -4}, Age: {4, -2} years",
                LegsLength, WingSpan, Name, Weight, Age);
            return strOut;
        }


    }
}
