using System;

namespace Calculatrice
{
    public class DivisionParZeroException : Exception
    {
        public DivisionParZeroException()
            : base("Division par zero impossible.")
        {
        }
    }
}
