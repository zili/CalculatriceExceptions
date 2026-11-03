namespace Calculatrice
{
    public class Calculatrice
    {
        public double LireNombre(string saisie)
        {
            double nombre;
            if (!double.TryParse(saisie, out nombre))
            {
                throw new EntreeNonNumeriqueException(saisie);
            }
            return nombre;
        }

        public double Calculer(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "x":
                    return a * b;
                case "/":
                    if (b == 0)
                    {
                        throw new DivisionParZeroException();
                    }
                    return a / b;
                default:
                    throw new OperationNonReconnueException(operation);
            }
        }
    }
}
