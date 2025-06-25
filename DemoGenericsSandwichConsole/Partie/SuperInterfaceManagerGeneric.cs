using System.Security.Cryptography.X509Certificates;

namespace DemoGenericsSandwichConsole.Partie
{
    public class SuperInterfaceManagerGeneric<T> where T : IScore
    {
        public T? PartieAvecLePlusPetitScore(T a, T b)
        {
            int difference = a.GetScore() - b.GetScore();
            if (difference < 0)
                return a;
            if (difference > 0)
                return b;
            return default;
        }
    }
}
