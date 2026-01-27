# POO: Création d'un rectangle

**Exercice :** Créer une classe `Personnage` avec :
- trois propriétés `name`, `health` et `damage`.
- une méthodes `attack()` qui prendra un `Personnage` en paramètre.
- une méthode `isAlive()` qui renverra un booléen pour indiquer si le personnage est encore en vie (HP >  0).
- les getters et setters nécessaires. 

La méthode `attack()` aura pour fonction : 
- diminuer les points de vie de l'adversaire passé en paramètre par le montant de l'attribut `damage`. 
- Afficher les nom de l'attaquant et de l'adversaire. 
- Indiquer le montant de vie restant de l'adversaire.

Créer ensuite un objet `p1` et `p2` à partir de cette classe, définir leurs propriétés, et dans une boucle appeler leur méthodes `attack()` et `isAlive()`. Tant que l'un des 2 personnages est toujours en état de combattre, continuer le combat jusqu'à obtention d'un vainqueur. (l'autre sera détruit par son destructeur). 

exemple : 

=== DEBUT ===
Gimli a attaqué Legolas
Il reste 5pv à Legolas 

Legolas a attaqué Gimli
Il reste 15pv à Gimli  

Gimli a attaqué Legolas
Il reste 0pv à Legolas

Legolas disparait.
Gimli gagne le combat !!!
=== FIN DU COMBAT ===
Gimli disparait.