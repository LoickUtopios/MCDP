using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage.Classes
{
    internal class Animal
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public Animal(string name) 
        {
            Name = name;
        }

        public void DonnerSonNom()
        {
            Console.WriteLine("Je suis un animal qui s'appelle " + Name);
        }

        // Pour effectuer du polymorphisme par override,
        // le parent doit spécifier que la méthode peut être réécrite avec le mot clé 'virtual'. 
        public virtual void Manger()
        {
            Console.WriteLine("L'animal mange"); 
        }


    }
}
