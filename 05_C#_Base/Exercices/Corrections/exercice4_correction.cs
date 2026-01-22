Console.WriteLine("Veuillez entrer la longueur : ");
float longueur = float.Parse(Console.ReadLine());

Console.WriteLine("Veuillez entrer la largeur : ");
float largeur = float.Parse(Console.ReadLine());

float perimetre = (longueur + largeur) * 2;
float aire = longueur * largeur;

Console.WriteLine($"Pour longueur ({longueur}) et largeur ({largeur}), nous avons : ");
Console.WriteLine($"\t- perimetre : {perimetre}");
Console.WriteLine($"\t- aire : {aire}");