using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Hedgehog : Animal
    {
        public Hedgehog(int age, string name, int weight, bool sonicOrNot) : base(age, name, weight)
        {
            KnowsSonic = sonicOrNot;
        }
        public bool KnowsSonic {  get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Spikety-spike, im gonna go and spikety-spike");
        }

        public override string Stats()
        {
            return new string($"KnowsSonic: {KnowsSonic}, {base.Stats()}");
        }
    }
}
