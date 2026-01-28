using DemoHeritage.Classes;

Animal animal = new Animal("Flipper");
Console.WriteLine(animal.Name);
animal.DonnerSonNom();
animal.Manger();

Chien chien = new Chien("Bull", 3);
Console.WriteLine(chien.Name);
Console.WriteLine(chien.Age);
chien.DonnerSonNom();
// J'appelle Aboyer avec différent type ou nombre de paramètre (grâce à la surcharge de méthode)
chien.Aboyer();
chien.Aboyer("le facteur");
chien.Aboyer(5);
chien.Manger();
chien.Action(); 


Animal chien2 = new Chien("Bill", 5);
chien2.DonnerSonNom(); // Affichage du parent (shadowing)
chien2.Manger(); // Affichage de l'enfant (override)

// chien2.Aboyer(); Erreur car la classe Animal ne possède pas cette méthode.