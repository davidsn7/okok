using System;

namespace LibrarieModele
{
    public enum StatusRezervare
    {
        InAsteptare,
        Confirmata,
        Anulata
    }

    [Flags]
    public enum PreferinteClient
    {
        Nimic = 0,
        AproapeDeEcran = 1,
        RandMijloc = 2,
        AleeLaterala = 4,
        ScaunIzolat = 8
    }

    [Flags]
    public enum CategorieSociala
    {
        Niciuna = 0,
        Elev = 1,
        Student = 2,
        Pensionar = 4,
        PersoanaCuDizabilitati = 8
    }

    public class Rezervare
    {
        public int Id { get; set; }
        public Proiectie Proiectie { get; set; }
        public string ClientNume { get; set; }
        public int Loc { get; set; }
        public StatusRezervare Status { get; set; }
        public PreferinteClient Preferinte { get; set; }
        public CategorieSociala Categorie { get; set; }
        public double PretFinal { get; set; }

        public Rezervare(int id, Proiectie proiectie, string client, int loc,
                         StatusRezervare status, PreferinteClient preferinte, CategorieSociala categorie)
        {
            Id = id;
            Proiectie = proiectie;
            ClientNume = client;
            Loc = loc;
            Status = status;
            Preferinte = preferinte;
            Categorie = categorie;
            PretFinal = CalculeazaReducere(proiectie.PretBilet, categorie);
        }

        public static double CalculeazaReducere(double pret, CategorieSociala cat)
        {
            if ((cat & CategorieSociala.Elev) == CategorieSociala.Elev) return pret * 0.5;
            if ((cat & CategorieSociala.Student) == CategorieSociala.Student) return pret * 0.7;
            if ((cat & CategorieSociala.Pensionar) == CategorieSociala.Pensionar) return pret * 0.6;
            if ((cat & CategorieSociala.PersoanaCuDizabilitati) == CategorieSociala.PersoanaCuDizabilitati) return pret * 0.4;
            return pret;
        }

        public string AfiseazaDetalii()
        {
            return $"Rezervare #{Id} | Client: {ClientNume} | Film: {Proiectie.Film.Titlu} | Loc: {Loc} | Pret: {PretFinal} lei | Categorie: {Categorie} | Status: {Status}";
        }

        public string ConversieLaSirFisier()
        {
            return $"{Id};{Proiectie.Id};{ClientNume};{Loc};{(int)Status};{(int)Preferinte};{(int)Categorie}";
        }
    }
}
