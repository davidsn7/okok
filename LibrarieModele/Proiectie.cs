using System;

namespace LibrarieModele
{

    public enum ZiuaSaptamanii
    {
        Luni,
        Marti,
        Miercuri,
        Joi,
        Vineri,
        Sambata,
        Duminica
    }

    [Flags]
    public enum TipAccesProiectie
    {
        Nimic = 0,
        Abonament = 1,
        Invitatie = 2,
        VIP = 4
    }


    public class Proiectie
    {
        public int Id { get; set; }
        public Film Film { get; set; }
        public Sala Sala { get; set; }
        public string OraProiectiei { get; set; }
        public ZiuaSaptamanii Zi { get; set; }
        public TipAccesProiectie Acces { get; set; }
        public double PretBilet { get; set; }

        public Proiectie(int id, Film film, Sala sala, string oraProiectiei, ZiuaSaptamanii zi, TipAccesProiectie acces, double pretBilet)
        {
            Id = id;
            Film = film;
            Sala = sala;
            OraProiectiei = oraProiectiei;
            Zi = zi;
            Acces = acces;
            PretBilet = pretBilet;

        }

        public string AfiseazaDetalii()
        {
            return $"ID: {Id} | Film: {Film.Titlu} | Sala: {Sala.Denumire} | Ora: {OraProiectiei} | Zi: {Zi} | Acces: {Acces} | Pret: {PretBilet} lei";
        }

        public string ConversieLaSirFisier()
        {
            return $"{Id};{Film.Id};{Sala.Id};{OraProiectiei};{(int)Zi};{(int)Acces};{PretBilet}";
        }

    }
}
