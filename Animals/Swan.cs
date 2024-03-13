using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animals
{
    internal class Swan : Bird
    {

        public Swan(int age, string name, int weight, bool attacker) : base(age, name, weight, false)
        {
            TheBastardThatAttackedMe = attacker;
        }

        //When I was about 4 years old, I was attacked by a Swan. 
        public bool TheBastardThatAttackedMe { get; set; }

        public override string Stats()
        {
            return new string($"TheBastardThatAttackedMe: {TheBastardThatAttackedMe}, {base.Stats()}");
        }
    }
}
