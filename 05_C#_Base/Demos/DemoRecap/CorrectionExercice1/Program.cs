//## Exercice FizzBuzz

//Écrire un programme qui affiche les nombres de **1 à 30**.

//Pour chaque nombre :

//-Si le nombre est divisible par **3**, afficher `Fizz`
//- Si le nombre est divisible par **5**, afficher `Buzz`
//- Si le nombre est divisible par **3 et par 5**, afficher `FizzBuzz`
//- Sinon, afficher le nombre

/* // Méthode 1 
for(int i = 1; i <= 30; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
        Console.WriteLine("FizzBuzz");
    else if (i % 5 == 0)
        Console.WriteLine("Buzz");
    else if (i % 3 == 0)
        Console.WriteLine("Fizz");
    else
        Console.WriteLine(i); 
}
*/

// Méthode 2 
string result;
for (int i = 1; i <= 30; i++)
{
    result = "";

    if (i % 3 == 0)
        result += "Fizz";

    if (i % 5 == 0)
        result += "Buzz";

    if (result == "")
        result += i; 

    Console.WriteLine(result);
}
