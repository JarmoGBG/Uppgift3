using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Errors
{
    internal class TooFewCharactersError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use too few characters in a text field. This fired an error!";
        }
    }
}
