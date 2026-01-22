Console.Write("Veuillez donner le poids : ");
float poids = float.Parse(Console.ReadLine());

Console.Write("Veuillez donner le mode de livraison : ");
string modeLivraison= Console.ReadLine().Trim().ToLower();

float price = -1;

if(poids > 0 && poids <= 1)
{
    if (modeLivraison == "standard")
        price = 4.99f;

    if (modeLivraison == "express")
        price = 7.99f;

    // price = modeLivraison == "standard" ? 4.99f : modeLivraison == "express" ? 7.99f : -1f; 
}
else if (poids <= 5)
{
    if (modeLivraison == "standard")
        price = 6.99f;

    if (modeLivraison == "express")
        price = 10.99f;
}
else
{
    if (modeLivraison == "standard")
        price = 9.99f;

    if (modeLivraison == "express")
        price = 14.99f;
}

if (poids > 0 && price != -1)
{
    Console.WriteLine("Le prix est de : " +  price);
}
else
{
    if (poids < 0)
        Console.WriteLine("Poids Invalide");

    if (price == -1)
        Console.WriteLine("Mode invalide");
}