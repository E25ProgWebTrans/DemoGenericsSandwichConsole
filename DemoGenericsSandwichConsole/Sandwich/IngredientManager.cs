namespace DemoGenericsSandwichConsole.Sandwich
{
    public class IngredientManager : SandwichMaker3000<Ingredient>, IIngredientManager
    {

        public Pain FaireDuPainBrun()
        {
            return new Pain() { EstBrun = true };
        }

        public Relish FaireDeLaRelishSucree()
        {
            return new Relish() { EstSucree = true };
        }

        public IReadOnlyList<Ingredient> FaireUnHorribleSandwich()
        {
            Pain pain = FaireDuPainBrun();
            Relish relish = FaireDeLaRelishSucree();

            return FaireUnSandwich(pain, relish);
        }
    }
}
