// See https://aka.ms/new-console-template for more information

using DemoGenericsSandwichConsole.Partie;
using DemoGenericsSandwichConsole.Sandwich;

// Exemple Interface #1
Console.WriteLine("Exemple Interface #1");
Partie partie1A = new Partie(3);
Partie partie1B = new Partie(4);

var sim1 = new SuperInterfaceManager();

Partie? partieAvecPlusPetitScore1 = (Partie?)sim1.PartieAvecLePlusPetitScore(partie1A, partie1B);
Console.WriteLine(partieAvecPlusPetitScore1.Score);

// Exemple Interface #1
/*Console.WriteLine();
Console.WriteLine("Exemple Interface #2");
Partie partie2A = new Partie(13);
Partie partie2B = new Partie(8);

// Dans cet exemple, on fait un seul appel à une méthode, donc on ne gagne pas grand chose
// Il faut s'imaginer que le même objet peut être utilisé plusieurs fois et que maintenant il est plus facile à utiliser
var sim2 = new SuperInterfaceManagerGeneric<Partie>();
Partie? partieAvecPlusPetitScore2 = sim2.PartieAvecLePlusPetitScore(partie2A, partie2B);
Console.WriteLine(partieAvecPlusPetitScore2.Score);*/

// Exemple Complexe #1
/*Console.WriteLine();
Console.WriteLine("Exemple Complexe #1");
var sandwichMaker = new SandwichMaker3000<string>();

string stringPain = "pain";
string stringGarniture = "garniture";

var sandwichString = sandwichMaker.FaireUnSandwich(stringPain, stringGarniture);
for (int i = 0; i < sandwichString.Count; i++)
{
    string s = sandwichString[i];
    Console.WriteLine(s);
}*/

// Exemple Complexe #2
/*Console.WriteLine();
Console.WriteLine("Exemple Complexe #2");
var sandwichMaker2 = new SandwichMaker3000<Ingredient>();

Pain pain = new Pain();
Relish relish = new Relish();

var sandwichIngredients = sandwichMaker2.FaireUnSandwich(pain, relish);
for(int i = 0; i < sandwichIngredients.Count; i++)
{
    Ingredient item = sandwichIngredients[i];
    Console.WriteLine(item);
}*/

// Exemple IngredientManager
Console.WriteLine();
Console.WriteLine("Exemple Ingredient Manager");
var ingredientManager = new IngredientManager();

var sandwichIngredients2 = ingredientManager.FaireUnHorribleSandwich();
for (int i = 0; i < sandwichIngredients2.Count; i++)
{
    Ingredient item = sandwichIngredients2[i];
    Console.WriteLine(item);
}

// Exemple IReadOnlyList
// Comme les méthodes FaireUnSandwich et FaireUnHorribleSandwich retournent des IReadOnlyList, on n'a pas accès à des méthodes comme Add
/*
List<int> l = new();
l.Add(1);
l.Remove(l[0]);

Relish plusRelish = new Relish();
sandwichIngredients2.Add(plusRelish);
sandwichIngredients2.Remove(sandwichIngredients2[0]);
*/


