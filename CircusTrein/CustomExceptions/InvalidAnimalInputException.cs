using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.CustomExceptions
{
    public class InvalidAnimalInputException : Exception
    {
        public InvalidAnimalInputException(string message) : base(message) { }
    }
}
