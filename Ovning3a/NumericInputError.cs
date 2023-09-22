using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.2 Polymorfism
namespace Ovning3a
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tride to usa a numeric input in a text only field. This fired an error!";
            
        }
    }
}
