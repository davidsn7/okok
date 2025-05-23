using Gestiune_Cinematograf.Clase;
using NivelStocareDate;
using System;

namespace Cinematograf
{
    class Program
    {
        static void Main()
        {
            AdministrareCinematograf admin = new AdministrareCinematograf();

            // Adăugare film
            Console.WriteLine("Introduceti un film (ID, Titlu, Regizor, Durata, Gen, Descriere):");
            int id = int.Parse(Console.ReadLine());
            string titlu = Console.ReadLine();
            string regizor = Console.ReadLine();
            int durata = int.Parse(Console.ReadLine());
            string gen = Console.ReadLine();
            string descriereFilm = Console.ReadLine();

            admin.AdaugaFilm(new Film(id, titlu, durata, gen, descriereFilm, regizor));

            // Adăugare sală
            Console.WriteLine("Introduceti o sală (ID, Nume, Capacitate):");
            int idSala = int.Parse(Console.ReadLine());
            string numeSala = Console.ReadLine();
            int capacitate = int.Parse(Console.ReadLine());

            admin.AdaugaSala(new Sala(idSala, numeSala, capacitate));

            // Afișare filme
            Console.WriteLine("\nFilmele salvate:");
            Film[] filme = admin.GetFilme();
            for (int i = 0; i < filme.Length; i++)
                Console.WriteLine(filme[i]);

            // Afișare săli
            Console.WriteLine("\nSălile salvate:");
            Sala[] sali = admin.GetSali();
            for (int i = 0; i < sali.Length; i++)
                Console.WriteLine(sali[i]);

            // Căutare film după titlu
            Console.WriteLine("\nIntrodu titlul filmului pentru căutare:");
            string cautareTitlu = Console.ReadLine();
            Film[] filmeGasite = admin.CautaFilmeDupaTitlu(cautareTitlu);

            Console.WriteLine("Filme găsite:");
            for (int i = 0; i < filmeGasite.Length; i++)
                Console.WriteLine(filmeGasite[i]);
        }
    }
}
