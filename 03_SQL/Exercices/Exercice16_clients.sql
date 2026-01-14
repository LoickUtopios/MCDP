USE formation_sql;

DROP TABLE IF EXISTS Achats; 
DROP TABLE IF EXISTS Clients;

-- Création des tables
CREATE TABLE Clients (
    id INT PRIMARY KEY,
    nom VARCHAR(50),
    prenom VARCHAR(50),
    ville VARCHAR(50)
);

CREATE TABLE Achats (
    id INT PRIMARY KEY,
    client_id INT,
    produit VARCHAR(50),
    montant DECIMAL(10, 2)
);

-- Insertion des données dans la table "Clients"
INSERT INTO Clients (id, nom, prenom, ville) VALUES
(1, 'Dupont', 'Jean', 'Paris'),
(2, 'Martin', 'Marie', 'Lyon'),
(3, 'Dubois', 'Pierre', 'Marseille'),
(4, 'Leclerc', 'Sophie', 'Lille'),
(5, 'Moreau', 'Luc', 'Bordeaux'),
(6, 'Bordeaux', 'François', 'Lille'),
(7, 'Ferry', 'Jules', 'Paris');

-- Insertion des données dans la table "Achats"
INSERT INTO Achats (id, client_id, produit, montant) VALUES
(1, 1, 'Téléphone', 500.00),
(2, 2, 'Ordinateur', 1200.00),
(3, 3, 'Télévision', 800.00),
(4, 1, 'Livre', 20.00),
(5, 4, 'Tablette', 350.00),
(6, 3, 'Console de jeux', 300.00),
(7, 5, 'Casque audio', 50.00),
(8, 2, 'Livre', 25.00),
(9, 1, 'Vêtements', 150.00),
(10, 4, 'Chaussures', 80.00),
(11, 8, 'Sac', 25.00);