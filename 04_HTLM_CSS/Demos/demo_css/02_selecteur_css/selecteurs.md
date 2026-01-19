Voici une liste des sélecteurs CSS, y compris les sélecteurs de base, les pseudo-classes et les pseudo-éléments :

### Sélecteurs de base
1. **Sélecteur universel**
   ```css
   * { }
   ```
2. **Sélecteur de type**
   ```css
   element { }
   ```
3. **Sélecteur de classe**
   ```css
   .classname { }
   ```
4. **Sélecteur d'ID**
   ```css
   #idname { }
   ```
5. **Sélecteur d'attribut**
   ```css
   [attribute] { }
   [attribute=value] { }
   [attribute~=value] { }
   [attribute|=value] { }
   [attribute^=value] { }
   [attribute$=value] { }
   [attribute*=value] { }
   ```

### Sélecteurs de combinaison
1. **Sélecteur descendant**
   ```css
   element element { }
   ```
2. **Sélecteur enfant direct**
   ```css
   element > element { }
   ```
3. **Sélecteur général de frère**
   ```css
   element ~ element { }
   ```
4. **Sélecteur adjacent de frère**
   ```css
   element + element { }
   ```

### Pseudo-classes
1. **Sélecteurs de lien**
   ```css
   :link { }
   :visited { }
   ```
2. **Sélecteurs d'action utilisateur**
   ```css
   :hover { }
   :active { }
   :focus { }
   :focus-within { }
   :focus-visible { }
   ```
3. **Sélecteurs de position**
   ```css
   :first-child { }
   :last-child { }
   :nth-child(n) { }
   :nth-last-child(n) { }
   :only-child { }
   ```
4. **Sélecteurs de type**
   ```css
   :first-of-type { }
   :last-of-type { }
   :nth-of-type(n) { }
   :nth-last-of-type(n) { }
   :only-of-type { }
   ```
5. **Pseudo-classes de forme**
   ```css
   :root { }
   :empty { }
   :target { }
   :lang(language) { }
   :is() { }
   :where() { }
   :not() { }
   ```
6. **Pseudo-classes de relation**
   ```css
   :has() { }
   ```
7. **Pseudo-classes de négociation**
   ```css
   :not(selector) { }
   ```

### Pseudo-éléments
1. **Pseudo-éléments de contenu**
   ```css
   ::before { }
   ::after { }
   ```
2. **Pseudo-éléments de texte**
   ```css
   ::first-letter { }
   ::first-line { }
   ```
3. **Autres pseudo-éléments**
   ```css
   ::selection { }
   ::backdrop { }
   ::placeholder { }
   ::marker { }
   ::spelling-error { }
   ::grammar-error { }
   ```

### Sélecteurs de l'état de l'élément
1. **Sélecteurs d'éléments de formulaire**
   ```css
   :enabled { }
   :disabled { }
   :checked { }
   :indeterminate { }
   :default { }
   :valid { }
   :invalid { }
   :in-range { }
   :out-of-range { }
   :required { }
   :optional { }
   :read-only { }
   :read-write { }
   ```

### Sélecteurs de groupe
1. **Groupe de sélecteurs**
   ```css
   selector1, selector2 { }
   ```

### Sélecteurs de négation
1. **Sélecteurs de négation**
   ```css
   :not(selector) { }
   ```

Ces sélecteurs couvrent une grande partie des cas d'utilisation courants pour le style des éléments HTML en CSS. Il existe d'autres sélecteurs spécifiques et avancés pour des cas particuliers.