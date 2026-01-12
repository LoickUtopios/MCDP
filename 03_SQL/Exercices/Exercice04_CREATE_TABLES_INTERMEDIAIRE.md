### Exercice: Création de tables

**Instructions :**  

1. Créez une base de données nommée `music_stream.

2. Créez une table `utilisateurs` contenant les infos suivantes :
  - Un identifiant unique pour chaque utilisateur (id_utilisateur)
  - Le nom d’utilisateur (nom_utilisateur) – requis
  - Une adresse email – unique
  - La date d’inscription – par défaut à la date/heure actuelle
  - Le pays d’origine de l’utilisateur

3. Créez une table `chansons` contenant les informations suivantes :
  - Un identifiant unique pour chaque chanson (id_chanson)
  - Le titre de la chanson
  - Le nom de l’artiste
  - Le nom de l’album
  - La durée de la chanson
  - Le genre musical
  - L’année de sortie

4. Créez une table `playlists` contenant les informations suivantes :

- Un identifiant unique pour chaque playlist (id_playlist)
- Le nom de la playlist
- L’identifiant de l’utilisateur qui a créé la playlist (id_utilisateur) – clé étrangère vers la table utilisateurs
- L'identifiant de la chansons intégrée dans la playlist (id_chanson) – clé étrangère vers la table chansons
- La date de création – par défaut à la date/heure actuelle
