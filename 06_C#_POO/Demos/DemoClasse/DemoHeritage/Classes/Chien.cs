using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage.Classes
{
    internal class Chien : Animal
    {
        private int _age;
        public int Age { get => _age; set => _age = value; }

        // Ici, pour construire mon Chien, j'appel au préalable le constructeur de mon parent
        // via le mot-clé base()
        public Chien(string name, int age) : base(name)
        {
            Age = age;
        }

        public void Aboyer()
        {
            Console.WriteLine("Le chien aboie"); 
        }

        public void Aboyer(string cible) // Polymorphisme par surcharge
        {
            Console.WriteLine("Le chien aboie sur " + cible);
        }

        public void Aboyer(int cible) // Polymorphisme par surcharge 
        {
            Console.WriteLine("Le chien aboie sur " + cible + " personnes");
        }

        public new void DonnerSonNom() // Polymorphise par shadowing / masquage
        {
            Console.WriteLine("Je suis un chien qui s'appel " + Name);
        }

        public override void Manger() // Polymorphisme par override / substitution
        {
            Console.WriteLine("Le chien mange"); 
        }

        public void Action()
        {
            // Avec base, nous pouvons appeler le comportement du parent directement. 
            base.DonnerSonNom();
            base.Manger();   
        }

    }
}
