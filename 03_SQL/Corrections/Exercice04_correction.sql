CREATE DATABASE IF NOT EXISTS music_stream; 

USE music_stream; 

CREATE TABLE IF NOT EXISTS utilisateurs (
	id_utilisateur INT AUTO_INCREMENT PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    date_inscription DATETIME DEFAULT CURRENT_TIMESTAMP,
    pays VARCHAR(255)
); 

CREATE TABLE IF NOT EXISTS chansons (
	id_chanson INT AUTO_INCREMENT PRIMARY KEY,
    titre VARCHAR(255) NOT NULL,
    artiste VARCHAR(255) NOT NULL,
    album VARCHAR(255) NOT NULL,
    duree TIME,
    genre VARCHAR(255),
    annee_sortie INT
); 

CREATE TABLE IF NOT EXISTS playlists (
	id_playlist INT AUTO_INCREMENT PRIMARY KEY,
    nom_playlist VARCHAR(255) NOT NULL,
	date_creation DATETIME DEFAULT CURRENT_TIMESTAMP,
    utilisateur_id INT NOT NULL,
    chanson_id INT,
    CONSTRAINT fk_utilisateur_id FOREIGN KEY (utilisateur_id) REFERENCES utilisateurs(id_utilisateur),
	CONSTRAINT fk_chanson_id FOREIGN KEY (chanson_id) REFERENCES chansons(id_chanson)
); 