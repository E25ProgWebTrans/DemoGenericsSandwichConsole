namespace DemoGenericsSandwichConsole.Sandwich
{
    public class Pain : Ingredient
    {
        public bool EstBrun { get; set; }

        public override string ToString()
        {
            return "Pain" + (EstBrun ? "Brun" : "Blanc");
        }
    }
}
