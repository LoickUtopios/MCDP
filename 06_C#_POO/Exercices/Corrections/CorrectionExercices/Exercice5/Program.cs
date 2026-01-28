using Exercice5.Classes;

Salarie chloe = new Salarie("Chloe", "IT", 24000);
Salarie pierre = new Salarie("Pierre", "Comptabilité", 30000);
Salarie sam = new Salarie("Sam", "Managment", 36000);

chloe.AfficherSalaire();
pierre.AfficherSalaire();
sam.AfficherSalaire();

Salarie.AfficherTotalSalaire();
Salarie.LicenciementTotal(); 
