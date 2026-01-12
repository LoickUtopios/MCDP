# Exercice 3 : Deux tables avec relation One-to-Many + contraintes

On veut gérer des **commandes** passées par des **clients**.

Crée les deux tables suivantes :

### **Table clients**

* id_client (entier, clé primaire)
* nom (texte)
* email (texte)

### **Table commandes**

* id_commande (entier, clé primaire)
* date_commande (date)
* montant (décimal)
* id_client (entier, clé étrangère)

**Contraintes obligatoires :**

* Relation **One-to-Many** (un client peut avoir plusieurs commandes)
* PK dans chaque table
* FK dans commandes
* NOT NULL, UNIQUE, CHECK selon le besoin