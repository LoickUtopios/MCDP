#  Système de commandes

- Ajouter les scripts : client.sql, commande.sql, commande_ligne.sql

1. Obtenir l’utilisateur ayant le prénom “Muriel” et le mot de passe “test11”, sachant que l’encodage du mot de passe est effectué avec l’algorithme Sha1.
2. Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes.
3. Obtenir la liste de tous les produits qui sont présent sur plusieurs commandes et y ajouter une colonne qui liste les identifiants des commandes associées.
4. Enregistrer le prix total à l’intérieur de chaque ligne des commandes, en fonction du prix unitaire et de la quantité
5. Obtenir le montant total pour chaque commande et y voir facilement la date associée à cette commande ainsi que le prénom et nom du client associé
6. (difficulté très haute) Enregistrer le montant total de chaque commande dans le champ intitulé “cache_prix_total”
7. Obtenir le montant global de toutes les commandes, pour chaque mois
8. Obtenir la liste des 10 clients qui ont effectué le plus grand montant de commandes, et obtenir ce montant total pour chaque client.
9.  Obtenir le montant total des commandes pour chaque date
10. Ajouter une colonne intitulée “category” à la table contenant les commandes. Cette colonne contiendra une valeur numérique
11. Enregistrer la valeur de la catégorie, en suivant les règles suivantes :
```bash
“1” pour les commandes de moins de 200€
“2” pour les commandes entre 200€ et 500€
“3” pour les commandes entre 500€ et 1.000€
“4” pour les commandes supérieures à 1.000€
```
12.  Créer une table intitulée “commande_category” qui contiendra le descriptif de ces catégories
13.  Insérer les 4 descriptifs de chaque catégorie au sein de la table précédemment créée
Supprimer toutes les commandes (et les lignes des commandes) inférieur au 1er février 2019. Cela doit être effectué en 2 requêtes maximum