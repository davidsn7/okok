using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareFilme
    {
        private string numeFisier;
        private List<Film> listaFilme;

        public AdministrareFilme(string numeFisier)
        {
            this.numeFisier = numeFisier;
            this.listaFilme = new List<Film>();

            CitesteDinFisier();
        }

        private void CitesteDinFisier()
        {
            if (!File.Exists(numeFisier))
                return;

            using (StreamReader cititor = new StreamReader(numeFisier))
            {
                string linie;
                while ((linie = cititor.ReadLine()) != null)
                {
                    string[] valori = linie.Split(';');

                    if (valori.Length != 9)
                        continue;

                    try
                    {
                        int id = int.Parse(valori[0]);
                        string titlu = valori[1];
                        int durata = int.Parse(valori[2]);
                        string regizor = valori[3];
                        string gen = valori[4];
                        string descriere = valori[5];
                        Limba limba = (Limba)int.Parse(valori[6]);
                        OptiuniFilm optiuni = (OptiuniFilm)int.Parse(valori[7]);
                        FormatFilm format = (FormatFilm)Enum.Parse(typeof(FormatFilm), valori[8]);

                        Film film = new Film(id, titlu, durata, regizor, gen, descriere, limba, optiuni, format);
                        listaFilme.Add(film);
                    }
                    catch
                    {
                        
                    }
                }
            }
        }

        public List<Film> GetListaFilme()
        {
            List<Film> filme = new List<Film>();

            if (File.Exists(numeFisier))
            {
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string linie;
                    while ((linie = sr.ReadLine()) != null)
                    {
                        string[] valori = linie.Split(';');
                        if (valori.Length == 9)
                        {
                            try
                            {
                                int id = int.Parse(valori[0]);
                                string titlu = valori[1];
                                int durata = int.Parse(valori[2]);
                                string regizor = valori[3];
                                string gen = valori[4];
                                string descriere = valori[5];
                                Limba limba = (Limba)int.Parse(valori[6]);
                                OptiuniFilm optiuni = (OptiuniFilm)int.Parse(valori[7]);
                                FormatFilm format = (FormatFilm)Enum.Parse(typeof(FormatFilm), valori[8]);

                                Film film = new Film(id, titlu, durata, regizor, gen, descriere, limba, optiuni, format);
                                filme.Add(film);
                            }
                            catch
                            {
                                
                            }
                        }
                    }
                }
            }

            return filme;
        }

        public void AdaugaFilm(Film film)
        {
            listaFilme.Add(film);
            ScrieInFisier(film);
        }

        private void ScrieInFisier(Film film)
        {
            using (StreamWriter scrie = new StreamWriter(numeFisier, append: true))
            {
                scrie.WriteLine(film.ConversieLaSirFisier());
            }
        }

        public Film CautaFilmDupaTitlu(string titlu)
        {
            foreach (Film film in listaFilme)
            {
                if (film.Titlu.ToLower() == titlu.ToLower())
                    return film;
            }
            return null;
        }

        public List<Film> CautaFilmDupaRegizor(string numeRegizor)
        {
            List<Film> rezultate = new List<Film>();

            foreach (Film film in listaFilme)
            {
                if (film.Regizor.ToLower().Contains(numeRegizor.ToLower()))
                    rezultate.Add(film);
            }
            return rezultate;
        }

        public void ActualizeazaFilm(Film filmActualizat)
        {
            for (int i = 0; i < listaFilme.Count; i++)
            {
                if (listaFilme[i].Id == filmActualizat.Id)
                {
                    listaFilme[i] = filmActualizat;
                    break;
                }
            }

            using (StreamWriter sw = new StreamWriter(numeFisier, false))
            {
                foreach (Film film in listaFilme)
                {
                    sw.WriteLine(film.ConversieLaSirFisier());
                }
            }
        }

    }
}
