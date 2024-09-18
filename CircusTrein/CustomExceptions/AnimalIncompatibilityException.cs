using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.CustomExceptions
{
    public class AnimalIncompatibilityException : Exception
    {
        public AnimalIncompatibilityException(string message) : base(message) { }
    }
}
