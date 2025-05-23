using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NivelStocareDate
{
    public class AdministrareSali
    {
        private string numeFisier;
        private List<Sala> listaSali;

        public AdministrareSali(string numeFisier)
        {
            this.numeFisier = numeFisier;
            this.listaSali = new List<Sala>();

            CitesteDinFisier();
        }

        public void AdaugaSala(Sala sala)
        {
            listaSali.Add(sala);
            ScrieInFisier(sala);
        }

        private void ScrieInFisier(Sala sala)
        {
            using (StreamWriter scrie = new StreamWriter(numeFisier, append: true))
            {
                scrie.WriteLine($"{sala.Id};{sala.Denumire};{sala.Capacitate};{(int)sala.Tip};{(int)sala.Dotari}");
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
                    string denumire = valori[1];
                    int capacitate = int.Parse(valori[2]);
                    TipSala tip = (TipSala)int.Parse(valori[3]);
                    DotariSala dotari = (DotariSala)int.Parse(valori[4]);

                    Sala sala = new Sala(id, denumire, capacitate, tip, dotari);
                    listaSali.Add(sala);
                }
            }
        }

        public List<Sala> GetListaSali()
        {
            return listaSali;
        }

        public Sala CautaSalaDupaId(int idCautat)
        {
            foreach (Sala sala in listaSali)
            {
                if (sala.Id == idCautat)
                    return sala;
            }
            return null;
        }
    }
}
