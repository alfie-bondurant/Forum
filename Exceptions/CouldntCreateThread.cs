using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Exceptions
{
    public class CouldntCreateThread : Exception
    {
        public CouldntCreateThread() : base() { }
    }
}