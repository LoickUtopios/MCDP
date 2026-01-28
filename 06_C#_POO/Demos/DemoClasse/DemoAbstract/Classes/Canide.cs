using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstract.Classes
{
    // Une classe abstraite ne peut etre instancié mais elle peut être hérité.
    internal abstract class Canide
    {
        private string _nom;

        public string Nom { get { return _nom; } set { _nom = value; } }

        public Canide(string nom)
        {
            Nom = nom;
        }

        public void Manger()
        {
            Console.WriteLine($"{Nom} mange.");
        }

        // Une méthode abstraite doit forcément être placé dans une classe abstraite.
        // Cette méthode DEVRA être implementer pour toutes les classes qui vont hériter de Canide.
        public abstract void Parler(); 


    }
}
