using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    internal class TooManyCharactersError : UserError
    {
        public override string UEMessage()
        {
            return ("You tried to use too many characters in a text field. This fired an error!");
        }
    }
}
