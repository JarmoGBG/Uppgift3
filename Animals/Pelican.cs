using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Pelican : Bird
    {
        public Pelican(int age, string name, int weight, bool knowsPalle) : base(age, name, weight, false)
        {
            KnowsPalleKuling = knowsPalle;  
        }

        public bool KnowsPalleKuling {  get; set; }
        public override string Stats()
        {
            return new string($"KnowsPalleKuling: {KnowsPalleKuling}, {base.Stats()}");
        }
    }
}
