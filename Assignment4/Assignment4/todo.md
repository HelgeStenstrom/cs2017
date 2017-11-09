# Att göra
* Ingredienslista ska vara tom när man gör ett nytt recept
* Receptlistan ska innehålla unika recept, och inte samma recept
  upprepat flera gånger.
  
* Edit-knappen och Delete-knappen i ingredienslistan ska fungera.

# Vad som ska hända
## FormMain
### Allmänt


### Klicka Add Inredients
* En FormIngredients skapas
* Om OK klickats utan att ingredienser lagts till; visa detta i dialogruta.

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


