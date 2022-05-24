using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Swan : Bird
    {
        double NeckLength { get; set; }
        public Swan(double neckLength, double wingSpan, string name, double weight, uint age) : base(wingSpan, name, weight, age)
        {
            NeckLength = neckLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("Swan's sound is: oh-OH, oh-OH, oh-OH!");
        }

        public override string ToString()
        {
            string strOut = string.Format("Swan: NeckLength: {0, -4} cm, WingSpan: {1, -4} cm,  Name: {2, -7}, Weight: {3, -4} cm, Age: {4, -2} years",
                NeckLength, WingSpan, Name, Weight, Age);
            return strOut;
        }
    }
}
