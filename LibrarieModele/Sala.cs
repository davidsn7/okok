using System;

namespace LibrarieModele
{

    public enum TipSala
    {
        Standard,
        IMAX,
        _4DX
    }


    [Flags]
    public enum DotariSala
    {
        Nimic = 0,
        VentilatieAutomata = 1,
        ScaunePremium = 2
    }
    public class Sala
    {
        public int Id { get; set; }

        public string Denumire { get; set; }
        public int Capacitate { get; set; }
        public TipSala Tip { get; set; }
        public DotariSala Dotari { get; set; }

        public Sala(int id, string denumire, int capacitate, TipSala tip, DotariSala dotari)
        {
            Id = id;
            Denumire = denumire;
            Capacitate = capacitate;
            Tip = tip;
            Dotari = dotari;
        }

        public string AfiseazaDetalii()
        {
            return $"ID: {Id} | Sala: {Denumire} | Capacitate: {Capacitate} | Tip: {Tip} | Dotari: {Dotari}";
        }

        public string ConversieLaSirFisier()
        {
            return $"{Id};{Denumire};{Capacitate};{(int)Tip};{(int)Dotari}";
        }

    }
}
