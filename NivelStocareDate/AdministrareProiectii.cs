using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class AdministrareProiectii
    {
        private string numeFisier;
        private List<Proiectie> listaProiectii;
        private List<Film> listaFilme;
        private List<Sala> listaSali;

        public AdministrareProiectii(string numeFisier, List<Film> listaFilme, List<Sala> listaSali)
        {
            this.numeFisier = numeFisier;
            this.listaProiectii = new List<Proiectie>();
            this.listaFilme = listaFilme;
            this.listaSali = listaSali;

            CitesteDinFisier();
        }

        public void AdaugaProiectie(Proiectie proiectie)
        {
            listaProiectii.Add(proiectie);
            ScrieInFisier(proiectie);
        }

        private void ScrieInFisier(Proiectie proiectie)
        {
            using (StreamWriter scrie = new StreamWriter(numeFisier, append: true))
            {
                scrie.WriteLine($"{proiectie.Id};{proiectie.Film.Id};{proiectie.Sala.Id};{proiectie.OraProiectiei};{(int)proiectie.Zi};{(int)proiectie.Acces};{proiectie.PretBilet}");
            }
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

                    int id = int.Parse(valori[0]);
                    int idFilm = int.Parse(valori[1]);
                    int idSala = int.Parse(valori[2]);
                    string ora = valori[3];
                    ZiuaSaptamanii ziua = (ZiuaSaptamanii)int.Parse(valori[4]);
                    TipAccesProiectie acces = (TipAccesProiectie)int.Parse(valori[5]);
                    double pret = double.Parse(valori[6]);

                    Film filmGasit = null;
                    Sala salaGasita = null;

                    foreach (Film film in listaFilme)
                    {
                        if (film.Id == idFilm)
                        {
                            filmGasit = film;
                            break;
                        }
                    }

                    foreach (Sala sala in listaSali)
                    {
                        if (sala.Id == idSala)
                        {
                            salaGasita = sala;
                            break;
                        }
                    }

                    if (filmGasit != null && salaGasita != null)
                    {
                        Proiectie proiectie = new Proiectie(id, filmGasit, salaGasita, ora, ziua, acces, pret);
                        listaProiectii.Add(proiectie);
                    }
                }
            }
        }

        public List<Proiectie> GetListaProiectii()
        {
            return listaProiectii;
        }

        public Proiectie CautaProiectieDupaId(int idCautat)
        {
            foreach (Proiectie proiectie in listaProiectii)
            {
                if (proiectie.Id == idCautat)
                    return proiectie;
            }
            return null;
        }
    }
}

       