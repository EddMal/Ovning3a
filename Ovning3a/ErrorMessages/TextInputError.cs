using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.2 Polymorfism
namespace Ovning3a.ErrorMessages
{
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tride to usa a text input in a numeric only field. This fired an error!";

        }
    }
}
