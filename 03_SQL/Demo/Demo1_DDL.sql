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

-- 