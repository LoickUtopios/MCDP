using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstract.Classes
{
    // Le sealed placer au niveau de la classe va empecher tout héritage
    internal sealed class Loup : Canide
    {
        public Loup(string nom) : base(nom)
        {
        
        }


        // La méthode Parler est obligatoire redéfinie car elle était abstraite dans la classe parent. 
        // Si sealed est placé dans une méthode, elle va en empecher la redéfinition.
        public sealed override void Parler()
        {
            Console.WriteLine("Le loup fait Woouuu !");
        }
    }
}
