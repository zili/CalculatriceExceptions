using System;

namespace CalculatriceApp
{
    public class DivisionParZeroException : Exception
    {
        public DivisionParZeroException()
            : base("Division par zero impossible.")
        {
        }
    }
}
