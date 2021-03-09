namespace ModelViewViewModel_Voorbeeld.Stap9
{
    class Persoon
    {
        public string Naam { get; set; }
        public string Geslacht { get; set; }
        public int Leeftijd { get; set; }

        public Persoon(string naam, string geslacht, int leeftijd)
        {
            this.Naam = naam;
            this.Geslacht = geslacht;
            this.Leeftijd = leeftijd;
        }

        public Persoon()
            : this("", "", 0)
        {

        }

        public void Verjaar()
        {
            Leeftijd += 1;
        }

        public override string ToString()
        {
            return Naam + " " + Geslacht + " " + Leeftijd.ToString();
        }
    }
}
