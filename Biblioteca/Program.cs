 /*Autore dostoevskij = new Autore("Fëdor", "Dostoevskij", new DateOnly(1821, 11, 11), true, new List<Libro>() );
    Autore Agatha = new Autore("Agatha", "Christie", new DateOnly(1890, 7, 15), false, new List<Libro>() );

    Libro uno = new Libro("Le notti bianche", dostoevskij, 1848, 130, 0);
    Libro due = new Libro("Delitto e castigo", dostoevskij, 1866, 608, 0);
    Libro tre = new Libro("I demoni", dostoevskij, 1872, 726, 0);
    Libro quattro = new Libro("Omicidio sull'Oriental Express", Agatha, 1934, 500, 0);*/
using System;
using System.IO;
Biblioteca biblio = new Biblioteca("ITIS Rossi", "Via Legione Galieno 52, Vicenza");



string Indirizzo = @"C:\Users\denis\biblioteca-in-csharp-DenisFaggionato\Biblioteca";
biblio.CaricaCSV(Indirizzo);
biblio.SalvaCSV(Indirizzo);

   /* biblio.AggiungiAutore(dostoevskij);
    biblio.AggiungiAutore(Agatha);
    biblio.AggiungiLibro(uno);
    biblio.AggiungiLibro(due);
    biblio.AggiungiLibro(tre);
    biblio.AggiungiLibro(quattro);
    biblio.ElencoBiblioteche.Add(biblio);
 
    biblio.CaricaCSV(@"");
    // Salvataggio su file CSV
    biblio.SalvaCSV(@"");

    // Pulizia delle liste
    biblio.ElencoBiblioteche.Clear();*/



    /*Console.WriteLine($"{biblio}\nElenco Autori:");
    foreach (Autore autore in biblio.ElencoAutori)
    {
        Console.WriteLine($"- {autore}\n  Libri presenti: {autore.Libri.Count}");
    }

    int idx = 0;
    Console.WriteLine("Elenco Libri:");
    foreach (Libro libro in biblio.ElencoLibri)
    {
        Console.WriteLine($"{++idx}. {libro}");
    }*/