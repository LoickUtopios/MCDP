//## Exercice — Message selon la note (switch expression)

//### Sujet

//Demander une note entière entre 0 et 20.

//- Si la saisie est invalide ou hors intervalle → `Note invalide`
//- Sinon produire un message **avec une switch expression** :

//Barème(différent de la démo) :

//-18..20 → `Excellent`
//- 15..17 → `Tres bien`
//- 12..14 → `Bien`
//- 10..11 → `Passable`
//- 0..9 → `Insuffisant`

//Afficher le message.


//Demander une note entière entre 0 et 20.
using System.Runtime.CompilerServices;

Console.WriteLine("Veuillez entrer une note : "); 
string inputStr = Console.ReadLine();

string message; 
bool noteOk = int.TryParse(inputStr, out int note);

if (!noteOk)
    message = "Note invalide";
else
{
    message = note switch
    {
        >= 18 and <= 20 => "Excellent", 
        >= 15 and <= 17 => "Tres bien",
        >= 12 and <= 14 => "Bien",
        >= 10 and <= 11 => "Passable",
        >= 0 and <= 9 => "Insuffisant",
        _ => "Note invalide"
    };
}

Console.WriteLine($"Votre note {note} : {message}" );