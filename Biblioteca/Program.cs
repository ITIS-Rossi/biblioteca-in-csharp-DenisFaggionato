Biblioteca biblio = new Biblioteca("ITIS Rossi", "Via Legione Galieno 52, Vicenza");

Autore dostoevskij = new Autore("Fëdor", "Dostoevskij", new DateTime(1821, 11, 11), true, biblio );
Autore Agatha = new Autore("Agatha", "Christie", new DateTime(1890, 7, 15), false, biblio );

Libro uno = new Libro("Le notti bianche", dostoevskij, 1848, 130, biblio);
Libro due = new Libro("Delitto e castigo", dostoevskij, 1866, 608, biblio);
Libro tre = new Libro("I demoni", dostoevskij, 1872, 726, biblio);
Libro quattro = new Libro("Omicidio sull'Oriental Express", Agatha, 1934, 500, biblio);
//Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");


string Indirizzo = @"C:\Users\denis\biblioteca-in-csharp-DenisFaggionato\Biblioteca";
biblio.CaricaCSV(Indirizzo);
biblio.SalvaCSV(Indirizzo);
