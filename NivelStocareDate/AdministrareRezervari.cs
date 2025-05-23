using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareRezervari
    {
        private string numeFisier;
        private List<Rezervare> listaRezervari;
        private List<Proiectie> listaProiectii;

        public AdministrareRezervari(string numeFisier, List<Proiectie> listaProiectii)
        {
            this.numeFisier = numeFisier;
            this.listaRezervari = new List<Rezervare>();
            this.listaProiectii = listaProiectii;

            CitesteDinFisier();
        }



        private void CitesteDinFisier()
        {
            if (!File.Exists(numeFisier))
                return;

            using (StreamReader cit = new StreamReader(numeFisier))
            {
                string linie;

                while ((linie = cit.ReadLine()) != null)
                {
                    string[] valori = linie.Split(';');

                    int id = int.Parse(valori[0]);
                    int idProiectie = int.Parse(valori[1]);
                    string numeClient = valori[2];
                    int loc = int.Parse(valori[3]);
                    StatusRezervare status = (StatusRezervare)int.Parse(valori[4]);
                    PreferinteClient preferinte = (PreferinteClient)int.Parse(valori[5]);
                    CategorieSociala categorie = (CategorieSociala)int.Parse(valori[6]);

                    Proiectie proiectieGasita = null;
                    foreach(Proiectie proiectie in listaProiectii)
                    {
                        if (proiectie.Id == idProiectie)
                        {
                            proiectieGasita = proiectie;
                            break;
                        }
                    }

                    if (proiectieGasita != null)
                    {
                        Rezervare rezervare = new Rezervare(id, proiectieGasita, numeClient, loc, status, preferinte, categorie);
                        listaRezervari.Add(rezervare);
                    }

                }
            }
        }

        public void AdaugaRezervare(Rezervare rezervare)
        {
            listaRezervari.Add(rezervare);
            ScrieInFisier(rezervare);
        }

        private void ScrieInFisier(Rezervare rezervare)
        {
            using (StreamWriter sw = new StreamWriter(numeFisier, append: true))
            {
                sw.WriteLine(rezervare.ConversieLaSirFisier());
            }
        }

        public List<Rezervare> GetListaRezervari()
        {
            return listaRezervari;
        }


    }
}
