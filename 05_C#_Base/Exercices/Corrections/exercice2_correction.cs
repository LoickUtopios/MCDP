
Console.WriteLine("Veuillez entrer un nombre a : ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Veuillez entrer un nombre b : ");
int b = int.Parse(Console.ReadLine());

int somme = a + b;

Console.WriteLine("La somme de a et b est : " + somme);

/* Methode 2 - securisé */

Console.WriteLine("Veuillez entrer un nombre a : ");
bool aIsOk = int.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Veuillez entrer un nombre b : ");
bool bIsOk = int.TryParse(Console.ReadLine(), out b);

if(aIsOk && bIsOk)
{
    somme = a + b;
    Console.WriteLine("La somme de a et b est : " + somme);
}
else
{
    Console.WriteLine("L'un des nombres, n'est pas un nombre..."); 
}
    