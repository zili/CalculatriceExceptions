# Calculatrice

Application console C# (.NET 10) qui simule une calculatrice en boucle, pour illustrer la gestion des exceptions.

## Fonctionnalités
- Saisie de deux réels a et b, puis d'une opération (`+ - x /`)
- Calcul et affichage du résultat
- Répétition tant que l'utilisateur répond `o`

## Exceptions personnalisées
- `EntreeNonNumeriqueException` : a ou b n'est pas un nombre
- `OperationNonReconnueException` : opération différente de `+ - x /`
- `DivisionParZeroException` : division par zéro

## Classes
- `Calculatrice` : lecture des nombres et calcul (lève les exceptions)
- `Program.cs` : boucle principale en instructions de haut niveau, sans méthode `Main` (intercepte les exceptions avec `try / catch / finally`)

## Exécution
```bash
dotnet run
```
