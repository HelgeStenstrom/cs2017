# Att göra
* Ingredienslista ska vara tom när man gör ett nytt recept
* Receptlistan ska innehålla unika recept, och inte samma recept
  upprepat flera gånger.
  
* Edit-knappen och Delete-knappen i ingredienslistan ska fungera.

# Vad som ska hända

## En session
1. Programmet startas.
2. Användaren skriver ett receptnamn i rutan i FormMain
3. Användaren väljer en kategor
4. Användaren klickar Add Ingredients
5. Formuläret FormIngredient visas
6. Skriv ni en ingredient i rutan
7. Klicka Add eller tryck Enter
8. Ingrediensen listas överst i ingredienslitan. 
9. Skriv in en ingrediens till, klicka Add
10. Nu syns två ingredienser i listan
11. Klicka OK
12. FormIngredients försvinner
13. Ska något speciellt synas i FormMain? Ska t.ex. receptet synas i
    receptlistan redan innan man klickat Add Recipe? Som jag förstår
    sida 2 av Assignment4, ska inget synas. 
14. Användaren klickar Add Recipe
15. _currentRecipe uppdateras från synliga fält i FormMain (behövs
    det, inget bore vara nytt)
16. _currentRecipe adderas (kopieras) till receptlistan
17. Grafiken uppdateras. Framför allt skrivs receptlistan om.

Lite senare...

18. Användaren klickar ett recept i receptlistan.
19. 



## FormMain
### Instansvariabler

* _recipeManager, har hand om många recept
* _currentRecipe, har hand om det recept som syns i GUI och som
  hanteras av FormIngredients. 
  * När ska _currentRecipe skapas?
  * När ska _currentRecipes innehåll skrivas om?


### Klicka Add Inredients
* En FormIngredients skapas, med _currentRecipe som argument
* Om OK klickats utan att ingredienser lagts till; visa detta i
  dialogruta.
* Om inte OK; uppdatera inte dialogrutorna. 

### Klicka Add Recipe
* ???
* UpdateGUI

### UpdateGUI 
* Fyll i listan över recept från recipeManager.RecipeListToString()
* Fyll i övrigt från currentRecipe?

## FormIngredients

### Allmänt
FormIngredients anropas med argumenet currentRecipe. Det är givet av
hjälpen. Det är alltså currentRecipe som kommer att påverkas när man
kör FormIngrediens.

Om FormIngredients skriver direkt i ingredienslistan för
currentRecipe, kommer den att påverkas antingen man trycker OK eller
Cancel. Eftersom Cancel-knappen finns, så antar jag att den ska ha den
funktion den säger. Vi kan inte jobba direkt i ingredienslistan.

Jag tror FormIngredients behöver en "currentIngredients", som är skild
från currentRecipe.Ingredients.

### OK
Kopiera currentIngredients till currentRecipe.Ingredients


### Cancel
Gör inget.

### Add

### Enter i Ingredient-fältet
Samma som Add


