using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.2 Polymorfism

namespace Ovning3a
{
    internal class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tride to usa a null input. This fired an error!";

        }
    }
}