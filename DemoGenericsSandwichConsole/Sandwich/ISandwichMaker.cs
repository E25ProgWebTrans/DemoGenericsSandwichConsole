namespace DemoGenericsSandwichConsole.Sandwich
{
    public interface ISandwichMaker<T>
    {
        public IReadOnlyList<T> FaireUnSandwich(T exterieur, T interieur);
    }
}
