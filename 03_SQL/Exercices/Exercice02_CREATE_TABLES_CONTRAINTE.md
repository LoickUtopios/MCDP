## Exercice : Création de tables avec contraintes

Supposons que vous devez créer une base de données pour une entreprise.

Créez une table nommée **utilisateurs** avec les colonnes suivantes :

* **id_utilisateur** (entier, clé primaire)
* **nom** (texte)
* **email** (texte)
* **age** (entier)
* **pays** (texte)

Ajoutez les contraintes suivantes :

* `nom` et `email` ne peuvent pas être `NULL`
* `email` doit être unique
* `age` doit être supérieur ou égal à 18
* `pays` a pour valeur par défaut `'France'`

Une fois la table créée, fournissez les commandes permettant de :

1. Renommer la table `utilisateurs` en `users`
2. Ajouter une colonne `prénom` de type `VARCHAR(200)`
3. Supprimer la contrainte sur `age`
4. Modifier le type de la colonne `nom` en `VARCHAR(200)`
