//# Exercice 13 — Compter les voyelles dans un mot (foreach sur string)

//Demander à l’utilisateur de saisir un mot.
//Parcourir chaque caractère du mot et compter le nombre de voyelles (`a, e, i, o, u, y`).

//À la fin, afficher le nombre de voyelles trouvées.

Console.WriteLine("Veuillez saisir un mot :");
string userInput = Console.ReadLine() ?? "";

int compteurVoyelle = 0;

foreach(char lettre in userInput)
{
    //if (lettre == 'a' || lettre == 'e' || lettre == 'i' || lettre == 'o' || lettre == 'u' || lettre == 'y')
    //    compteurVoyelle++; 

    if ("aeiouy".Contains(lettre))
        compteurVoyelle++;
}

Console.WriteLine($"Votre mot contient {compteurVoyelle} voyelle(s).");