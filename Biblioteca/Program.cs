Autore dostoevskij = new Autore("Fëdor", "Dostoevskij", new DateOnly(1821, 11, 11), true);
Autore Agatha  = new Autore("Agatha ", "Christie", new DateOnly(1890, 7, 15), false );

Libro uno = new Libro("Le notti bianche", dostoevskij, 1848, 130);
Libro due = new Libro("Assassinio sull'Oriental Expresse", Agatha, 1934, 65);

Console.WriteLine(dostoevskij);
Console.WriteLine(Agatha);

int idx = 0;
foreach(Libro liber in new Libro[]{uno, due})
    Console.WriteLine($"Libro n.{++idx}: {liber}");

