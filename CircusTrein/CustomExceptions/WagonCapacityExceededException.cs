using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.CustomExceptions
{
    public class WagonCapacityExceededException : Exception
    {
        public WagonCapacityExceededException(string message) : base(message) { }
    }
}
