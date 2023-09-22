using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.2 Polymorfism
namespace Ovning3a
{
    internal class ToFewCharactersInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tride to usa a input in with to few characters. This fired an error!";

        }
    }
}