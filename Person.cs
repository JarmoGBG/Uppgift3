using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    internal class Person
    {
        private int age;

        private string fName;

        private string lName;

        private double height;

        private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException($"The Age property must be a positive integer, the supplied value was {value}");
                }

            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException($"The FName property must be at least 2 characters and no more than 10 characters, the supplied string was {value.Length} characters.");
                }
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15) 
                {
                    lName = value;

                }
                else
                {
                    throw new ArgumentException($"The LName property must be at least 3 characters and no more than 15 characters, the supplied string was {value.Length} characters.");
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException($"The Height property must be a positive number, the supplied value was {value}.");
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"The Weight property must be a positive number, the supplied value was {value}.");
                }
            }
        }
    }
}
