namespace NivelStocareDate
{
    public class AdministrareCinematograf
    {
        private Film[] filme = new Film[10];
        private int nrFilme = 0;

        private Sala[] sali = new Sala[10];
        private int nrSali = 0;

        public void AdaugaFilm(Film film)
        {
            if (nrFilme < filme.Length)
                filme[nrFilme++] = film;
        }

        public void AdaugaSala(Sala sala)
        {
            if (nrSali < sali.Length)
                sali[nrSali++] = sala;
        }

        public Film[] GetFilme()
        {
            Film[] rezultat = new Film[nrFilme];
            for (int i = 0; i < nrFilme; i++)
                rezultat[i] = filme[i];
            return rezultat;
        }

        public Sala[] GetSali()
        {
            Sala[] rezultat = new Sala[nrSali];
            for (int i = 0; i < nrSali; i++)
                rezultat[i] = sali[i];
            return rezultat;
        }

        // Căutare filme după titlu
        public Film[] CautaFilmeDupaTitlu(string titlu)
        {
            Film[] rezultat = new Film[nrFilme];
            int nrGasite = 0;

            for (int i = 0; i < nrFilme; i++)
            {
                if (filme[i].Titlu.Contains(titlu))
                {
                    rezultat[nrGasite] = filme[i];
                    nrGasite++;
                }
            }

            Film[] rezultatFinal = new Film[nrGasite];
            for (int i = 0; i < nrGasite; i++)
                rezultatFinal[i] = rezultat[i];

            return rezultatFinal;
        }
    }
}