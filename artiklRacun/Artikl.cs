namespace artiklRacun
{
    public class Artikl
    {
        public string naziv;
        public int kolicina;
        public int cijena;

        public Artikl(string naz, int cij, int kol)
        {
            this.naziv = naz;
            this.cijena = cij;
            this.kolicina = kol;
        }
    }
}