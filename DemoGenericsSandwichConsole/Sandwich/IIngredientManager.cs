namespace DemoGenericsSandwichConsole.Sandwich
{
    public interface IIngredientManager : ISandwichMaker<Ingredient>
    {
        public Pain FaireDuPainBrun();

        public Relish FaireDeLaRelishSucree();
    }
}
