# Compte bancaire

**Exercice :** Créer une classe `CompteBancaire` avec les propriétés suivantes : `titulaire` (chaîne de caractères), `solde` (nombre à virgule flottante) et `devise` (chaîne de caractères). La classe doit avoir un constructeur qui prend en paramètres le nom du titulaire, le solde initial et la devise, et qui initialise les propriétés correspondantes. La classe doit également avoir les méthodes suivantes :

- `deposer(montant)` : ajoute le montant spécifié au solde du compte.
- `retirer(montant)` : retire le montant spécifié du solde du compte, à condition que le solde soit suffisant.
- `afficherSolde()` : affiche le solde du compte avec la devise.

Créez ensuite un objet `compte` à partir de la classe `CompteBancaire` en utilisant le constructeur pour initialiser ses propriétés. Déposez ensuite de l'argent sur le compte en utilisant la méthode `deposer()`, retirez de l'argent du compte en utilisant la méthode `retirer()`, et affichez le solde du compte en utilisant la méthode `afficherSolde()`. 

Créez ensuite deux autres classes `CompteEpargne` et `CompteCourant` qui héritent de la classe `CompteBancaire`. La classe `CompteEpargne` doit avoir une propriété `tauxInteret` (nombre à virgule flottante) et une méthode `calculerInterets()` qui calcule les intérêts générés par le solde du compte en utilisant le taux d'intérêt. La classe `CompteCourant` doit avoir une propriété `decouvertAutorise` (nombre à virgule flottante) et une méthode `retirerAvecDecouvert(montant)` qui permet de retirer de l'argent même si le solde est insuffisant, à condition que le montant ne dépasse pas le découvert autorisé.

Créez ensuite un objet `compteEpargne` à partir de la classe `CompteEpargne` et un objet `compteCourant` à partir de la classe `CompteCourant`. Déposez ensuite de l'argent sur les deux comptes en utilisant la méthode `deposer()`, calculez les intérêts générés par le compte d'épargne en utilisant la méthode `calculerInterets()`, retirez de l'argent du compte courant en utilisant la méthode `retirerAvecDecouvert($montant)`, et affichez le solde des deux comptes en utilisant la méthode `afficherSolde()`.