using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Wolf : Animal
    {
        public Wolf(int age, string name, int weight, bool inNovel) : base(age, name, weight)
        {
            HasStarredInAJackLondonNovel = inNovel; 
        }
        public bool HasStarredInAJackLondonNovel { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Hoooowl!! Barking at the moon");
        }

        public override string Stats()
        {
            return new string($"HasStarredInAJackLondonNovel: {HasStarredInAJackLondonNovel}, {base.Stats()}");
        }
    }
}
