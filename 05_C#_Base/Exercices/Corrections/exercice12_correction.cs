//# Exercice 12 Table de multiplication (for)

//Demander à l’utilisateur de saisir un entier.
//Afficher la table de multiplication de cet entier de `1` à `10` à l’aide d’une boucle `for`.


Console.WriteLine("Veuillez saisir un entier : ");

int userInput;

if (int.TryParse(Console.ReadLine(), out userInput))
{
    for(int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i} * {userInput} = {i * userInput}");
    }
}
else
{
    Console.WriteLine("Votre saisie est invalide !"); 
}
