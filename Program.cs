using System;
using CalculatriceApp;

Calculatrice calculatrice = new Calculatrice();
string reponse = "o";

while (reponse == "o")
{
    try
    {
        Console.Write("a = ");
        double a = calculatrice.LireNombre(Console.ReadLine());
        Console.Write("b = ");
        double b = calculatrice.LireNombre(Console.ReadLine());
        Console.Write("Operation (+ - x /) : ");
        string operation = Console.ReadLine();
        double resultat = calculatrice.Calculer(a, b, operation);
        Console.WriteLine($"{a}  {operation}  {b} = {resultat}");
    }
    catch (EntreeNonNumeriqueException e)
    {
        Console.WriteLine($"Erreur de saisie : {e.Message}");
    }
    catch (OperationNonReconnueException e)
    {
        Console.WriteLine($"Erreur d'operation : {e.Message}");
    }
    catch (DivisionParZeroException e)
    {
        Console.WriteLine($"Erreur de calcul : {e.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Erreur inattendue : {e.Message}");
    }
    finally
    {
        Console.WriteLine("Fin du calcul.");
    }

    Console.Write("Continuer ? (o/n) : ");
    reponse = Console.ReadLine();
    Console.WriteLine();
}

Console.WriteLine("Au revoir.");
