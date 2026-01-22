
int a = 5;
int b = 10;
int c;

c = a; 
a = b; 
b = c;
Console.WriteLine($"La valeur de a est {a} et la valeur b est {b}");

/* Méthode 2 */

int A = 5;
int B = 10;

A = A + B;
B = A - B;
A = A - B;

Console.WriteLine($"La valeur de a est {A} et la valeur b est {B}");
