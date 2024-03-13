using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Errors
{
    internal class NegativeNumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a negative number in a field that requires a positiver number. This fired an error!";
        }
    }
}
