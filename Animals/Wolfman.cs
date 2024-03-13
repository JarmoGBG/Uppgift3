using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(int age, string name, int weight) : base(age, name, weight, false) { }

        public void Talk()
        {
            Console.WriteLine("I am Jack, I wonder how I still can talk...");
        }

        //F13 : If all birds need a new attribute, it should be placed in Bird class.
        //F14 : If it was all animals that needed the new attribute, it should be placed in the Animals class.
    }
}