﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Exceptions
{
    internal class NegativeAmountException : Exception //implements einai :
    {
        public NegativeAmountException( string s ) : base (s)
        {
            
        }
    }
}
