using System;

namespace CalculatriceApp
{
    public class EntreeNonNumeriqueException : Exception
    {
        public EntreeNonNumeriqueException(string saisie)
            : base($"Entree non numerique : {saisie}.")
        {
        }
    }
}
