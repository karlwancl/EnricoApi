using System;
using System.Collections.Generic;
using System.Text;

namespace EnricoApi
{
    public class EnricoException : Exception
    {
        public EnricoException(string message) : base(message)
        {

        }
    }
}
