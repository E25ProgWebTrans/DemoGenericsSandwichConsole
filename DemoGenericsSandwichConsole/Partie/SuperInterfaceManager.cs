using System.Security.Cryptography.X509Certificates;

namespace DemoGenericsSandwichConsole.Partie
{
    public class SuperInterfaceManager
    {
        public IScore? PartieAvecLePlusPetitScore(IScore a, IScore b)
        {
            int difference = a.GetScore() - b.GetScore();
            if (difference < 0)
                return a;
            if (difference > 0)
                return b;
            return default;
        }

        // Cette méthode est simplement présente pour donner un exemple d'utilisation
        public static void Main()
        {
            Partie partieA = new Partie(3);
            Partie partieB = new Partie(4);

            var sim = new SuperInterfaceManager();

            Partie? partieAvecPlusPetitScore = (Partie?)sim.PartieAvecLePlusPetitScore(partieA, partieB);
        }
    }
}
