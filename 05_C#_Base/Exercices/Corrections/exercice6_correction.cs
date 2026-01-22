
//Demander à l’utilisateur :

//-un premier entier `a`
//- un opérateur parmi `+`, `-`, `*`, `/`
//- un second entier `b`

//Afficher le résultat.
//Contraintes :

//-utiliser `TryParse` pour `a` et `b` (si invalide → message d’erreur)
//- si l’opérateur est inconnu → `Operateur invalide`
//- si division par 0 → `Division impossible`


// Demander à l'utilisateur 'a' et 'b'
Console.WriteLine("Veuillez entrer un nombre a : "); 
string aStr = Console.ReadLine();

Console.WriteLine("Veuillez entrer un nombre b : ");
string bStr = Console.ReadLine();

// Vérifier si a et b sont convertissable
bool aOk = int.TryParse(aStr, out int a);
bool bOk = int.TryParse(bStr, out int b);

// SI non-convertissable 
if(!aOk || !bOk)
{
    // Afficher une erreur
    Console.WriteLine("Erreur, les nombres sont invalides !");
}
else // Sinon
{
    // Demander opérateur à l'utilisateur
    Console.WriteLine("Veuillez donner un opérateur (*, /, +, -) :"); 
    string operateur = Console.ReadLine();


    switch (operateur)
    {
        // Si l'opérateur est '+'
        case "+":
            // Afficher la somme
            Console.WriteLine("La somme est de : " + (a + b));
            break;
        // Si l'opérateur est '-'
        case "-":
            // Afficher la soustraction
            Console.WriteLine("La différence est de : " + (a - b));
            break;
        // Si l'opérateur est '*'
        case "*":
            // Afficher la produit
            Console.WriteLine("Le produit est de : " + (a * b));
            break;
        // Si l'opérateur est '/'
        case "/":
            // Afficher la division
            if (b == 0)
                Console.WriteLine("Division par 0, impossible !");
            else 
                Console.WriteLine("Le quotient est de : " + (a / b));

            break;
        // Sinon
        default:
            // Afficher erreur operateur
            Console.WriteLine("Erreur, opérateur invalide");
            break; 
    }
}