using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Worm : Animal    
    {
        public Worm(int age, string name, int weight, bool hat) : base(age, name, weight)
        {
            WearsATyroleanHat = hat;
        }
        public bool WearsATyroleanHat { get; set; }

        public override void DoSound()
        {
            //ChatGPTs idea of what a worm with vocal chords would say when enthusiastically cheering 
            Console.WriteLine("Wiggle-woo!");
        }

        public override string Stats()
        {
            return new string($"WearsATyroleanHat: {WearsATyroleanHat}, {base.Stats()}");
        }

    }
}
