using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    internal class Person
    {
        private string fName;
        private string lName;
        private double? height;
        private double? weight;
        private uint? age;

        public Person(string fName, string lName)
        {
            if (fName.Length >= 2 && fName.Length <= 10)
                this.fName = fName;
            else
            {
                throw new ArgumentException("Förnamnet får inte vara mindre än 2 tecken eller längre än 10 tecken");
            }

            if (lName.Length >= 3 && lName.Length <= 15)
                this.lName = lName;
            else
            {
                throw new ArgumentException("Efternamnet får inte vara mindre än 3 tecken eller längre än 15 tecken");
            }

            this.height = null;
            this.weight = null;
            this.age = null;
        }

        public Person(string fName, string lName, double? height, double? weight, uint? age): this(fName, lName)
        {
            if (height > 0)
                this.height = height;
            else
            {
                throw new ArgumentException("Längden ska vara ett nummer större än 0");
            }

            if (weight > 0)
                this.weight = weight;
            else
            {
                throw new ArgumentException("Längden ska vara ett nummer större än 0");
            }

            if (age > 0)
                this.age = age;
            else
            {
                throw new ArgumentException("Åldern ska vara ett nummer större än 0");
            }
        }  
        
        public Person (Person pers): this (pers.fName, pers.lName, pers.height, pers.weight, pers.age)
        {
        }

        public string FName 
        {
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                    fName = value;
                else
                {
                    throw new ArgumentException("Förnamnet får inte vara mindre än 2 tecken eller längre än 10 tecken");
                }
            }   
            get { return fName;}              
        }

        public string LName 
        {
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                    lName = value;
                else
                {
                    throw new ArgumentException("Efternamnet får inte vara mindre än 3 tecken eller längre än 15 tecken");
                }
            }
            get { return lName; }
        }

        public double? Height 
        {
            set
            {
                if (value > 0)
                    height = value;
                else
                {
                    throw new ArgumentException("Längden ska vara ett nummer större än 0");
                }
            }
            get { return height; }
        }

        public double? Weight 
        {
            set
            {
                if (value > 0)
                    weight = value;
                else
                {
                    throw new ArgumentException("Vikten ska vara ett nummer större än 0");
                }
            }
            get { return weight; }
        }
        
        public uint? Age
        {
            set 
            { 
                if( value > 0 )
                    age = value;
                else
                {
                    throw new ArgumentException("Åldern ska vara ett nummer större än 0 ");
                }
            }
            get { return age; }
        }

        public override string ToString()
        {
            string strOut = string.Format("{0, -10} {1, -10} {2, -5} {3, -5} {4, -5}", 
                FName, LName, Age.ToString(), Height.ToString(), Weight.ToString());
            return strOut;
        }
    }
}
