using DemoClasse.Classes;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Voiture v1 = new Voiture(4, 5, "Mercedes", "Classe 1"); // Appel le constructeur correspondant
            v1.Model = "ClassA"; // On utilise le set de la propriété

            Console.WriteLine(v1.Model); // On utilise le get de la propriété
            Console.WriteLine(v1._nbPneu); // On affiche directement l'attibut (possible car elle est public)

            v1.StartEngine();
            v1.StartEngine();

            Voiture v2 = new Voiture(4, 3, "Chevrolet", "Aveo");
            v2.StartEngine();

            Console.WriteLine(v2);
        }
    }
}