using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasse.Classes
{
    internal class Voiture
    {
        // Attributs
        public int _nbPneu; // Attribut publique (accès à tous)
        private int _nbPorte; // Attibut privé (accessible uniquement dans la classe)
        private string _marque;
        private string _model;

        // Propriétés
        // Get permet la récupération de donnée
        // Set est uniqument pour la modification de donnée
        public int NbPorte { get => _nbPorte; set => _nbPorte = value; }
        public string Marque { get => _marque; set => _marque = value; }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public bool IsStarted { get; set; } = false;

        // Constructeur
        public Voiture() { }
        public Voiture(int nbPneu, int nbPorte, string marque, string model)
        {
            _nbPneu = nbPneu; // Attribut accéder directement (public)
            NbPorte = nbPorte; // Attribut accéder via leur propriété
            Marque = marque;
            Model = model;
        }

        // Méthodes (fonctions de la classe)
        public void StartEngine()
        {
            if (!IsStarted)
            {
                Console.WriteLine($"La voiture {Model} démarre !!! ");
                IsStarted = true;
            }
            else
            {
                Console.WriteLine("Crrrrrrrr la voiture est déjà démarré !!!!");
            }
            
        }

        public override string ToString()
        {
            return $"Je suis une voiture de marque {Marque} et de model {Model}. J'ai {_nbPneu} pneus et {NbPorte} portes.";
        }
    }
}
