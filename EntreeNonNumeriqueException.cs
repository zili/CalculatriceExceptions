using System;

namespace Calculatrice
{
    public class EntreeNonNumeriqueException : Exception
    {
        public EntreeNonNumeriqueException(string saisie)
            : base("Entree non numerique : '" + saisie + "'.")
        {
        }
    }
}
