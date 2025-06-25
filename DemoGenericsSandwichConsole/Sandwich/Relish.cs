namespace DemoGenericsSandwichConsole.Sandwich
{
    public class Relish : Ingredient
    {
        public bool EstSucree { get; set; }

        public override string ToString()
        {
            return "Relish " + (EstSucree ? "Sucrée" : "Non Sucrée");
        }
    }
}
