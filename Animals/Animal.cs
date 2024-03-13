using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return new string($"Age: {Age}, Name: {Name}, Weight: {Weight}");
        }

        protected Animal(int age, string name, int weight)
        {
            Age = age;
            Name = name;
            Weight = weight;
        }
    }
}