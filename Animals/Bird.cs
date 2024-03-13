using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Bird : Animal
    {
        public Bird(int age, string name, int weight, bool surfin) : base(age, name, weight)
        {
            IsASurfinBird = surfin;
        }

        public bool IsASurfinBird { get; set; }

        public override void DoSound()
        {
            if (IsASurfinBird)
            {
                Console.WriteLine("B-b-b bird, bird, bird, b-bird's the word");
            }
            else
            {
                Console.WriteLine("Quack Quack! I wish I knew The Trashmen!");
            }
        }

        public override string Stats()
        {
            return new string($"IsASurfinBird: {IsASurfinBird}, {base.Stats()}");
        }
    }
}
