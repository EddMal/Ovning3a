using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.2 Polymorfism

namespace Ovning3a.ErrorMessages
{
    internal class WhitespaceInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tride to usa a whitespace input. This fired an error!";

        }
    }
}