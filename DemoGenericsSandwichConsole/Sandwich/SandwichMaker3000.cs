namespace DemoGenericsSandwichConsole.Sandwich
{
    public class SandwichMaker3000<T> : ISandwichMaker<T>
    {
        public IReadOnlyList<T> FaireUnSandwich(T exterieur, T interieur)
        {
            var liste = new List<T>();

            liste.Add(exterieur);
            liste.Add(interieur);
            liste.Add(exterieur);

            return liste;
        }
    }
}
