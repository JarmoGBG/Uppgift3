using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Flamingo : Bird
    {
        public Flamingo(int age, string name, int weight, bool isPartOf) : base(age, name, weight, false)
        {
            IsPartOfAQuintet = isPartOf;
        }

        public bool IsPartOfAQuintet { get; set; }

        public override string Stats()
        {
            return new string($"IsPartOfAQuintet: {IsPartOfAQuintet}, {base.Stats()}");
        }
    }
}
