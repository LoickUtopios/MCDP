using DemoAbstract.Classes;

// Canide canide = new Canide(); // Erreur, une classe abstraite ne peut pas être instancié.

Loup loup = new Loup("Balto");
Console.WriteLine(loup.Nom);
loup.Manger();
loup.Parler();

Louveteau louveteau = new Louveteau("Bolto");
louveteau.Manger();
louveteau.Parler();

Coyote coyote = new Coyote("BipBip");
coyote.Manger();
coyote.Parler();

Canide[] lesCanides = {loup, coyote};

foreach(Canide canide in lesCanides)
{
    if(canide is Loup)
        Console.WriteLine("C'est un loup : ");

    if (canide is Coyote)
        Console.WriteLine("C'est un coyote : ");

    canide.Manger();
    canide.Parler();
}
