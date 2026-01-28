using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4.Classes
{
    internal class Chien
    {
        // Attributs
        private string _nom;
        private string _race;
        private int _age;
        private static string _nomDuChenil = "Mon chenil";
        private static int _nbChiens;

        // Propriété
        public string Nom { get { return _nom; } set { _nom = value; } }
        public string Race { get { return _race; } set { _race = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public static string NomDuChenil { get { return _nomDuChenil; } set { _nomDuChenil = value; } }
        public static int NbChiens { get { return _nbChiens; } set {_nbChiens = value; } }

        // Constructeur
        public Chien(string nom, string race, int age)
        {
            Nom = nom;
            Race = race;
            Age = age;
            NbChiens++; 
        }

        public override string ToString()
        {
            return $"Le chien {Nom} est un {Race} de {Age} ans. Qui fait parti du chenil {NomDuChenil}.";
        }
    }
}
