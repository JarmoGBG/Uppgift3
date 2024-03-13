using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Dog : Animal
    {
        public Dog(int age, string name, int weight, bool drools) : base(age, name, weight)
        {
            DroolsALot = drools;
        }
        public bool DroolsALot {  get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Gawrsh! A-Hyuck");
        }

        public override string Stats()
        {
            return new string($"DroolsALot: {DroolsALot}, {base.Stats()}");
        }

        public string DogStringMethod()
        {
            return new string("This is a dog string");
        }
    }
}
