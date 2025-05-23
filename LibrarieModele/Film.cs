using System;

namespace LibrarieModele
{
    public enum Limba
    {
        Romana,
        Engleza,
        Franceza
    }

    [Flags]
    public enum OptiuniFilm
    {
        Fara_optiuni = 0,
        Subtitrare = 1,
        UltraHD = 2,
        Avertizare18 = 4,
        Avertizare12 = 8
    }

    public enum FormatFilm
    {
        D2,
        D3
    }

    public class Film
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public int Durata { get; set; }
        public string Regizor { get; set; }
        public string Gen { get; set; }
        public string DescriereFilm { get; set; }
        public Limba Limba { get; set; }
        public OptiuniFilm Optiuni { get; set; }
        public FormatFilm Format { get; set; }

        public Film(int id, string titlu, int durata, string regizor, string gen, string descriere, Limba limba, OptiuniFilm optiuni, FormatFilm format)
        {
            Id = id;
            Titlu = titlu;
            Durata = durata;
            Regizor = regizor;
            Gen = gen;
            DescriereFilm = descriere;
            Limba = limba;
            Optiuni = optiuni;
            Format = format;
        }

        public string afiseazaDetalii()
        {
            return $"ID: {Id} | Titlu: {Titlu} | Gen: {Gen} | Durata: {Durata} min | Regizor: {Regizor} | Limba: {Limba} | Optiuni: {Optiuni} | Format: {Format}";
        }

        public string ConversieLaSirFisier()
        {
            return $"{Id};{Titlu};{Durata};{Regizor};{Gen};{DescriereFilm};{(int)Limba};{(int)Optiuni};{Format.ToString()}";
        }
    }
}
