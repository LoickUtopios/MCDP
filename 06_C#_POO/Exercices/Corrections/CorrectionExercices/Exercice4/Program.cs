using Exercice4.Classes;

Chien chien1 = new Chien("Rex", "Berger Allemand", 3);
Chien chien2 = new Chien("Idéfix", "Fox Terrier", 4);
Chien chien3 = new Chien("Beethoven", "Saint-Bernard", 5);

chien1.Nom = "Rox";
chien1.Age = 5;

Console.WriteLine(chien1);
Console.WriteLine(chien2);
Console.WriteLine(chien3);

Chien.NomDuChenil = "Best Chenil Ever";

Console.WriteLine(chien1);
Console.WriteLine(chien2);
Console.WriteLine(chien3);