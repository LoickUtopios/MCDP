# Forme (abstraction)

**Exercice :** Créez une classe abstraite `Forme` représentant une forme géométrique. Elle aura une propriété `nom` qui stockera le nom de la forme. Elle possédera également les méthodes suivantes : 

- `calculerAire()` (abstraite) qui calcul l'aire de la forme. 
- `calculerPerimetre()` (abstraite) qui calcul son périmètre. 
- `infos()` qui donnera les informations de la forme. 

Vous créerai ensuite 2 classe qui héritent de Forme : 

- `Rectangle`, avec les propriétés longueur et largeur
- `Cercle`, avec la propriété rayon 

Puis vous implémenterai les méthodes en conséquences. 

Enfin créez un objet `rectangle` et un objet `cercle` à l'aide de leur constructeur puis affichez leur infos (nom, propriété, perimetre, aire). 