Autore dostoevskij = new Autore("Fëdor", "Dostoevskij", new DateOnly(1821, 11, 11), true);
Autore Agatha  = new Autore("Agatha ", "Christie", new DateOnly(1890, 7, 15), false );

Libro uno = new Libro("Le notti bianche", dostoevskij, 1848, 130);
Libro due = new Libro("Delitto e castigo", dostoevskij, 1866, 608);
Libro tre = new Libro("I demoni", dostoevskij, 1872, 726 );




Console.WriteLine(dostoevskij);
foreach(Libro liber in dostoevskij.LibriPubblicati)
    Console.WriteLine($"-{liber}");
