/* --------------------------------------------------
 * TUPLES 
 * --------------------------------------------------
 * Le tuple permet de regrouper plusieurs valeurs de types différents
 * Les données sont non-modifiables (immutables)
 * 
*/

// Packing (affectation direct)
// (type1, type 2, ...) nomTuple = (valeur1, valeur2, ...)
(string, string, int) person = ("Toto", "Tata", 30); 

// Accès aux éléments via ItemX
Console.WriteLine("Affichage du tuple person : ");
Console.WriteLine(person);
Console.WriteLine(person.Item1);
Console.WriteLine(person.Item2);
Console.WriteLine(person.Item3);


(string prenom, string nom, int age) person2 = ("Marco", "Polo", 40);
(string prenom, string nom, int age) person3 = person; 

// Accès aux éléments via leur nom
Console.WriteLine("Affichage du tuple person via nom : ");
Console.WriteLine(person2);
Console.WriteLine(person2.prenom + " , " + person2.nom + " , " + person2.age);

// Unpacking : décomposition du tuple dans plusieurs variables
Console.WriteLine("Affichage du tuple person via Unpacking : ");
(string prenom, string nom, int age) = person;
Console.WriteLine(prenom);
Console.WriteLine(nom);
Console.WriteLine(age);

// Renommage des éléments d'un tuple 
(string LePrenom, string LeNom, int LAge, string email) person4 = 
    (person3.prenom, person3.nom, person3.age, "test@test.com");

Console.WriteLine("Affichage du tuple person4 après renommage: ");
Console.WriteLine(person4.LePrenom);
Console.WriteLine(person4.LeNom);
Console.WriteLine(person4.LAge);
Console.WriteLine(person4.email);
