// Commentaire rapide en C#

/*
    Commentaire sur plusieurs lignes
*/

/* -------------------------------------------------------
 * LES VARIABLES EN C#
 * 
 * Une variable permet de stocker une valeur en mémoire
 * afin de la réutiliser plus tard dans le programme.
 * -------------------------------------------------------
*/

// Une variable est définie par :
// - un type
// - un identificateur (nom)

// Elle peut être déclarer sans valeur initial.

/*
 * DECLARATION D'UNE VARIABLE 
 * 
 * Syntaxe : <type> <nom> = <valeur>;
*/
string nom = "Toto";

// Type possible en C# 
sbyte unOctet;      // -128 127 
byte octerPositif;  // entier sur 1 octet => 0 255 
short unPetitNombre;// entier sur 2 octet => -32000 32000
int age;            // entier sur 4 octet => -2 milliard 2 milliard
long presqueInfinie;// entier sur 8 octet  => Très grand

bool estVrai;       // Booléen => Vrai / Faux

float distance;     // décimal sur 4 octet 
double monnaie;     // décimal sur 8 octet (plus précis)

string chaineDeMot; // chaine de caractere
char uneLettre;     // un seul caractere

// Le séparateur '_' est autorisé pour améliorer la visibilité
presqueInfinie = 100_000_000L;

// Pour un float, nous devons ajouter un 'f' à la fin (obligatoire)
distance = 12.5f; 

chaineDeMot = "Ceci est une phrase";
uneLettre = 'a';


/* -------------------------------------------------------
 * Interaction Console : Affichage (Write Line/ Write)
 * -------------------------------------------------------
 * 
 * Console.WriteLine(...) : écrit un texte puis ajoute un saut de ligne.
 * Console.Write(...) : écrit un texte sans ajout d'un saut de ligne.
 * 
*/

Console.WriteLine("Affichage direct");
Console.WriteLine(presqueInfinie);
Console.WriteLine(chaineDeMot);

Console.Write("Bonjour");
Console.Write(" à tous");

Console.WriteLine(); // retour à la ligne sans écriture.

// Il est possible d'utiliser des symbole spéciaux pour la typo des chaines de caractere
// \t permet d'effectuer une tabulation
Console.WriteLine("\tBonjour avec une tabulation."); 

// \n permet de faire un retour à la ligne manuellement.
Console.Write("Bonjour \nJ'effectue un saut de ligne\navec plusieurs saut\nd'affilé\n");

/* -------------------------------------------------------
 * Interaction Console : Lecture clavier (ReadLine)
 * -------------------------------------------------------
 * 
 * Console.ReadLine(...) : lit la chaine écrite dans la console
 * 
*/

Console.WriteLine("Quel est votre nom ?"); 
string nomUtilisateur = Console.ReadLine();

Console.WriteLine("Votre nom est " + nomUtilisateur); // Concaténation 

Console.WriteLine("Quel est votre prenom ?");
string? prenomUtilisateur = Console.ReadLine(); // string? va récupérer une chaine ou null

Console.WriteLine("Quel est votre age ?");
int ageUtilisateur = int.Parse(Console.ReadLine()); // Parse va permettre la conversion de string vers int

// L'interpolation permet d'ajouter des variables dans une chaine directement (sans +).
Console.WriteLine($"Votre prenom est {prenomUtilisateur} et vous avez {ageUtilisateur} ans.");


/* -------------------------------------------------------
 * Cast : Transformation d'un type en un autre type
 * -------------------------------------------------------
 * 
 * Il est possible de connaitre le type d'une valeur avec GetType()
 * 
 * On distingue : 
 *      - conversion implicite : automatique (sans perte de d'information) 
 *      - conversion explicite : nécessite un cast (risque de perte)
 * 
*/


// Cast implicite
// short -> int (plus petit vers plus grand)
short petitNombre = 5;
int nombre = petitNombre;

// Un nombre décimal peut récupérer un entier de façon implicite (si la taille de l'entier est plus petit que le decimal)
float nombreAVirgule = petitNombre; 


// Cast explicite (manuel)
// int -> short (short est plus petit donc il y a un risque de dépassement)
nombre = 100_000;
petitNombre = (short) nombre; // Comme int et short sont de la même 'famille' on peut le cast avec : (type) <variable>

string nombreEnChaine = "255";
petitNombre = short.Parse(nombreEnChaine); // Pas de la même famille, il faut donc un cast particulier via Parse.


/* -------------------------------------------------------
 * Opérateur arithmétiques (+, -, *, /, %)
 * -------------------------------------------------------
 * 
 * Sur des entiers (int), la division / produit un résultat entier.
 * 
*/

int valeur = 5;
valeur = valeur + 5; // 10 
valeur = valeur - 5; // 5
valeur = valeur * 5; // 25
valeur = valeur / 5; // 5 
valeur = valeur % 5; // 0 (5 / 5 = 1 donc pas de reste)


// Incrémentation + Décrémentation 
int compteur = 0;

compteur++; // compteur = compteur + 1;
compteur += 5; // compteur = compteur + 5

Console.WriteLine(compteur++); // si le ++ est à la fin, l'incrémentation est faite après l'instruction.
Console.WriteLine(++compteur); // si le ++ est au début, l'incrémentation est faite avant la lecture de l'instruction.

compteur--; // compteur = compteur - 1
compteur -= 5; // compteur = compteur - 5;

compteur *= 2; // compteur = compteur * 2;

// Opérateurs d'expressions

int value1 = 1;
int value2 = 2;
bool resultat;

resultat = value1 == value2; // false

resultat = value1 <= value2; // true
resultat = value1 < value2; //true
resultat = value1 > value2; // false
resultat = value1 >= value2; // false

resultat = value1 != value2; // true

// Opérateurs logiques

resultat = true && true; // ET (les 2 conditions doivent être vrai)
resultat = true || false; // OU (une des conditions doit être vrai)
resultat = !false; // NOT (l'inverse de la condition donnée)

resultat = (true && false) || true || (false || false); // true

/* -------------------------------------------------------
 * Structures conditionnelles : if / else if / else
 * -------------------------------------------------------
 * if exécute un bloc si la condition est vrai.
 * 
 * Il peut ne pas prendre d'accolades si elle ne possède qu'une instruction
 * 
 * Syntaxe : 
 * if (condition){ 
 *      instruction; 
 * }
 * 
*/

if (3 > 2)
    Console.WriteLine("3 est supérieur à 2");

int note = 18;

if(note >= 16)
{
    Console.WriteLine("Très bien !");
}
else if(note >= 10)
{
    Console.WriteLine("Bien");
}
else
{
    Console.WriteLine("Assez bien"); 
}

/* -------------------------------------------------------
 * Structures conditionnelles : switch
 * -------------------------------------------------------
 * execute un bloc d'instructions si un choix rentre dans l'un des cas
 * 
*/

Console.WriteLine("1- Dire bonjour");
Console.WriteLine("2- Dire au revoir");
Console.WriteLine("3- Dire bonne nuit");

int choix = 5;

// Switch classique 
// - break termine un case
// - default gère les valeurs non prévues
switch (choix)
{
    case 1:
        Console.WriteLine("Bonjour !!!!");
        break;
    case 2:
        Console.WriteLine("Au revoir !!!");
        break;
    case 3:
        Console.WriteLine("Bonne nuit ~~~~"); 
        break;
    default:
        Console.WriteLine("Mauvais choix !!"); 
        break;
}

// switch expression (renvoie une valeur)
// Utile si l'objectif est de produire une valeur plutot que d'executer plusieurs instructions
string messageChoix = choix switch
{
    1 => "Bonjour !!!",
    2 => "Au revoir !!",
    3 => "Bonne nuit !!!",
    _ => "Je n'ai pas un choix valide !"
};

// switch expression - avec expression dans les cases 
// Utile si la valeur renvoyé dépend d'une plage de valeur.
int value = 15; 

string result = value switch
{
    <10 => "La valeur est inférieur à 10",
    >10 and <20 => "La valeur est compris entre 10 et 20",
    21 or 22 => "La valeur est 21 ou 22", 
    _ => "La valeur est 23 ou plus"
};

// Opérateur Ternaire (condition simple - if..else)
// Structure : <condition> ? <valeur_si_vrai> : <valeur_si_faux>
// Utilise pour produire une valeur courte sur une condition simple
int userAge = 20; 

bool majeur = userAge >= 18 ? true : false; 

// Null coalescing operateur ?? et ??= 
// --------------------------------------------------------
// ?? : si la valeur de gauche est null, on prend la valeur de droite
// ??= : si la variable est null, on lui affecte la valeur de droite

string? chaine1 = null;

string name= chaine1 ?? "TOTO"; // name = "TOTO" car chaine1 est null

chaine1 ??= "TITI"; // chaine1 étant null, il devient "TITI"
chaine1 ??= "TATA"; // chaine n'est pas null, il reste "TITI"

// Lecture console + TryParse (conversion sécurisé)
// -------------------------------------------------------------------------
// int.Parse(...) tente la conversion mais lève une exception si la conversion est impossible
// int.TryParse(...) renvoie True/False si la conversion est possible ou non 

Console.WriteLine("Entrez un nombre : ");
string? saisie = Console.ReadLine();

bool conversionOk = int.TryParse(saisie, out int n); // n prendra la valeur convertie (si possible) ou null

Console.WriteLine("Conversion réussi : " + conversionOk);
Console.WriteLine("Valeur obtenue : " + n);
Console.WriteLine();

/* -------------------------------------------------------
 * Structures itératives : while / do..while / for / foreach
 * -------------------------------------------------------
 * Donne un bloc itératif afin de répéter un bloc d'instructions à certaint nombre de fois
 * 
*/

/* 
 * While : boucle conditionnel
 *  - La condition doit être vérifié AVANT d'enter dans la boucle
 *  - Donc la boucle peut être executé 0 fois jusqu'à l'infinie (attention à la condition) 
 * 
*/

Console.WriteLine("Boucle WHILE ");
Console.WriteLine("Entrer un entier entre 1 et 5 : ");
string saisieNb = Console.ReadLine();
int nb; 

while (!int.TryParse(saisieNb, out nb) || nb < 1 || nb > 5)
{
    Console.WriteLine("Saisie Invalide ! Entrer un entier entre 1 et 5 : ");
    saisieNb = Console.ReadLine();
}


Console.WriteLine("Ok, valeur accepte : " + nb);
Console.WriteLine();

/* 
 * Do...While : boucle conditionnel
 *  - La condition doit être vérifié APRES d'enter dans la boucle
 *  - Donc la boucle peut être executé au moins 1 fois jusqu'à l'infinie (attention à la condition) 
 * 
*/


Console.WriteLine("Boucle DO..WHILE ");

// la variable choice (étant dans notre condition) doit être déclarer
// à l'extérieur de la boucle. 
string choice;
do
{
    Console.WriteLine("Menu: (a) Afficher heure | (b) Afficher date | (q) Quitter");
    choice = Console.ReadLine();

    if (choice == "a")
        Console.WriteLine("Heure : " + DateTime.Now.ToString("HH:mm:ss"));
    else if (choice == "b")
        Console.WriteLine("Date : " + DateTime.Now.ToString("yyyy-MM-dd"));
    else if (choice != "q")
        Console.WriteLine("Choix invalide");

} while (choice != "q");
Console.WriteLine();


/* 
 * For : boucle itérative avec variable d'itération
 *  - Nombre d'itération souvent connue à l'avance
 *  - La variable (compteur / i) est déclarer dans le for 
 * 
*/

Console.WriteLine("For : compteur de 1 a 5");

for(int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();

/* 
 * Foreach : boucle itérative sur une collections (tableaux, liste, ...)
 *  - Pas besoin de connaitre la taille de la collections (elle sera entièrement parcourue)
 * 
*/


Console.WriteLine("Foreach : afficher les lettres de l'alphabet");

foreach (char lettre in "abcdefghijklmnopqrstuvwxyz")
{
    Console.Write(lettre + " - ");
}
Console.WriteLine();

/* 
 * break / continue (complément aux boucles)
 *      - break : permet de sortir immédiatement de la boucle
 *      - continue : passer à l'itération suivante
*/


Console.WriteLine("Utilisation du break et continue");

for(int i = 0; i<= 10; i++)
{
    if (i == 5) 
    {
        Console.WriteLine("On passe le 5 avec continue");
        continue; 
    }

    if (i == 8)
    {
        Console.WriteLine("Je suis arrivé au 8, je break et sors de la boucle");
        break;
    }

    Console.WriteLine("Compteur : " + i);
}
Console.WriteLine();