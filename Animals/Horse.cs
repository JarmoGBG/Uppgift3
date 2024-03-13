using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Horse : Animal
    {
        public Horse(int age, string name, int weight, bool scanOrNot) : base(age, name, weight)
        {
            WillEndUpAtScanSlaughterHouse = scanOrNot;
        }
        public bool WillEndUpAtScanSlaughterHouse {  get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Neigh! Neigh! Never let me go.");
        }

        public override string Stats()
        {
            return new string($"WillEndUpAtScanSlaughterHouse: {WillEndUpAtScanSlaughterHouse}, {base.Stats()}");
        }
    }
}
