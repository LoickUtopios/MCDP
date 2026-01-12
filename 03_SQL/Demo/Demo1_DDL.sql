-- DDL : DATA DEFINITION LANGAGE
-- Pour faire un commentaire, on utilise deux "-" suivie d'un espace.

-- Création d'une base de données
-- La création d'une base de données MySQL/MariaDB implique de créer une seconde connexion.
-- Pour s'assurer de l'existence (ou non) d'un élément, nous pouvons ajouter :
-- IF EXISTS ou IF NOT EXISTS
CREATE DATABASE IF NOT EXISTS demo1; 

-- Suppression d'une base de données
DROP DATABASE IF EXISTS demo1;

-- Pour travailler dans une base de donnée spécifique, il est nécessaire de le spécifier.
USE demo1;

-- ---------- CREATE TABLE --------------

-- Pour créer une table, on utilise l'instruction CREATE TABLE
-- On peut vérifier son existance.
CREATE TABLE IF NOT EXISTS Personne (
  id INT,
  nom VARCHAR(255),
  prenom VARCHAR(255),
  age INT
); 

-- Suppression d'une table
DROP TABLE IF EXISTS Personne; 

-- Pour modifier une table, nous utilisons le mot-clé ALTER TABLE
-- Pour la modification, nous pouvons ajouter des colonnes.
ALTER TABLE Personne
ADD COLUMN phone VARCHAR(15);

-- Pour modifier le type d'une colonne
ALTER TABLE Personne
MODIFY phone INT; 

-- Pour supprimer une colonne
ALTER TABLE Personne
DROP COLUMN phone; 

-- Nous pouvons renommer une table
ALTER TABLE Personne
RENAME TO Person;

-- Créer une table avec des contraintes
CREATE TABLE IF NOT EXISTS Salarie (
  -- Primary Key permet d'ajouter une contrainte de type clé primaire (UNIQUE + NOT NULL)
  salarie_id INT AUTO_INCREMENT PRIMARY KEY,
  -- Not Null est une contrainte empechant l'absence de valeur
  prenom VARCHAR(255) NOT NULL,
  nom VARCHAR(255) NOT NULL,
  -- La contrainte CHECK permet d'ajouter un mécanisme de vérification
  age INT NOT NULL CHECK (age >= 18),
  -- La contrainte DEFAULT permet de définir une valeur par défaut en cas d'absence de valeur.
  salaire DECIMAL DEFAULT 1500.0
  service_id INT NOT NULL,
  -- Il est possible d'ajouter des contraintes nommée avec le mot-clé CONSTRAINT
  -- Pour les clé étrangères, nous devons renseigner le chams de la table salarie qui sera notre clé-étrangère.
  -- Puis dans REFERENCES, nous devons spécifier la table et la clé primaire qui serait en relation.
  CONSTRAINT fk_service_id FOREIGN KEY (service_id) REFERENCES Services(service_id) 
)