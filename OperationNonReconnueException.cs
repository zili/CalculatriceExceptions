using System;

namespace Calculatrice
{
    public class OperationNonReconnueException : Exception
    {
        public OperationNonReconnueException(string operation)
            : base("Operation non reconnue : '" + operation + "'. Utilisez + - x /.")
        {
        }
    }
}
