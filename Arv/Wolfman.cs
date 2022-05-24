using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Wolfman : Wolf, IPerson
    {

        public Wolfman(string color, string name, double weight, uint age): base(color, name, weight, age)
        {
            
        }

        public void Talk()
        {
            Console.WriteLine("Wolfman's says: \"Hello Woof\"!");
        }

        public override string Stats()
        {
            string strOut = string.Format("Wolfman is: Color: {0, -7}, Name: {1, -7}, Weight: {2, -4}, Age: {3, -3} years",
                Color, Name, Weight.ToString(), Age.ToString());
            return strOut;
        }

    }
}
