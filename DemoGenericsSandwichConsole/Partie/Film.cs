namespace DemoGenericsSandwichConsole.Partie
{
    public class Film : IScore
    {
        public int NotePopulaire { get; set; }
        public int NoteCritiques { get; set; }
        // De nombreux autres champs pour l'information de ma partie!

        public Film(int notePopulaire, int noteCritiques)
        {
            NotePopulaire = notePopulaire;
            NoteCritiques = noteCritiques;
        }

        public int GetScore()
        {
            return (NoteCritiques + NotePopulaire)/2;
        }
    }
}
