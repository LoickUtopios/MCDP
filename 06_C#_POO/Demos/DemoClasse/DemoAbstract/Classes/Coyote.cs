using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstract.Classes
{
    internal class Coyote : Canide
    {
        public Coyote(string nom) : base (nom)
        {
            
        }

        public override void Parler()
        {
            Console.WriteLine("Le coyote fait Wapiti !");
        }
    }
}
