Autore dostoevskij = new Autore("Fëdor", "Dostoevskij", new DateOnly(1821, 11, 11), true);
Autore Agatha  = new Autore("Agatha ", "Christie", new DateOnly(1890, 7, 15), false );

Libro uno = new Libro("Le notti bianche", dostoevskij, 1848, 130);
Libro due = new Libro("Delitto e castigo", dostoevskij, 1866, 608);
Libro tre = new Libro("I demoni", dostoevskij, 1872, 726 );
Libro quattro = new Libro("Omicidio sull'Oriental Express", Agatha, 1934, 500 );


Biblioteca biblio = new Biblioteca("ITIS Rossi", "Via Legione Galieno 52, Vicenza");
biblio.AggiungiAutore(dostoevskij);
biblio.AggiungiAutore(Agatha);
biblio.AggiungiLibro(uno);
biblio.AggiungiLibro(due);
biblio.AggiungiLibro(tre);
biblio.AggiungiLibro(quattro);

Console.WriteLine($"{biblio}\n Elenco Autori:");
foreach(Autore autore in biblio.ElencoAutori)
    Console.WriteLine($"-{autore}\n libri presenti : {autore.LibriPubblicati.Length}");
int idx = 0;
Console.WriteLine("Elenco Libri:");

foreach(Libro liber in biblio.ElencoLibri)
    Console.WriteLine($"{++idx}. {liber}");




