CREATE DATABASE demo2;

USE demo2;

CREATE TABLE IF NOT EXISTS services (
	service_id INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(255),
    date_creation DATE DEFAULT (CURRENT_DATE)
);

CREATE TABLE IF NOT EXISTS salarie (
	salarie_id INT AUTO_INCREMENT PRIMARY KEY,
    prenom VARCHAR(255) NOT NULL,
    nom VARCHAR(255) NOT NULL,
    age INT NOT NULL CHECK (age >= 18),
    salaire DECIMAL DEFAULT 1500.0,
    service_id INT
); 

INSERT INTO services (libelle)
VALUES
	('Informatique'),
    ('Ressources Humaines'),
    ('Comptabilite'); -- Un service qui ne va pas posséder de salarie
    
INSERT INTO salarie (nom, prenom, age, salaire, service_id)
VALUES
	("Dupont", "Jean", 30, 1400, 1),
    ("Dufour", "Michelle", 29, 2900,2),
    ("De rives", "Geralt", 24, 1500, 1),
    ("Dandelion", "Jasquier", 41, 2100, 2),
    ("Jager", "Eren", 20, 3500, 1),
    ("Ackerman", "Mikasa", 25, 2200, 1),
    ("Pinkman", "Jessie", 30, 3000, 2),
    ("White", "Walter", 27, 600, 3); -- Un salarie qui possede un service inexistant
    
-- Pour joindre 2 tables ensembles, nous devons préciser la table à joindre après le type de jointue a effectué
-- Ici, les jointures sont de type INNER JOIN (uniquement les données qui peuvent être jointes)
SELECT salarie.*, services.*
FROM salarie
INNER JOIN services
ON salarie.service_id = services.service_id;

-- Le LEFT JOIN va récupérer les valeurs croiser PLUS les valeurs de la table FROM
SELECT sa.*, se.*
FROM salarie AS sa
LEFT JOIN services AS se
ON sa.service_id = se.service_id;

-- Le RIGHT JOIN va récupérer les valeurs croiser PLUS les valeurs de la table du JOIN
SELECT salarie.*, services.*
FROM salarie
LEFT JOIN services
ON salarie.service_id = services.service_id;

-- Le FULL JOIN, récupere les données jointes PLUS les données du FROM PLUS les données du JOIN
SELECT salarie.*, services.*
FROM salarie
LEFT JOIN services
ON salarie.service_id = services.service_id
UNION
SELECT salarie.*, services.*
FROM salarie
RIGHT JOIN services
ON salarie.service_id = services.service_id;

