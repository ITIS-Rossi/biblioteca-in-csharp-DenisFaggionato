public class Biblioteca
{
    public List<Biblioteca> ElencoBiblioteche = new List<Biblioteca>();

    private string Nome;
    private string Indirizzo;
    public List<Libro> ElencoLibri;
    public List<Autore> ElencoAutori;

    public Biblioteca(string NomeBiblioteca, string IndirizzoBiblioteca)
    {
        this.Nome = NomeBiblioteca;
        this.Indirizzo = IndirizzoBiblioteca;
        this.ElencoLibri = new List<Libro>();
        this.ElencoAutori = new List<Autore>();
    }

public void AggiungiLibro(Libro libro)
{
    ElencoLibri.Add(libro);
    libro.Biblioteca = this;
}

    public void AggiungiAutore(Autore autore)
    {
        this.ElencoAutori.Add(autore);
    }

    public Autore[] AutoriAnno(DateTime anno)
    {
        List<Autore> annoAutori = new List<Autore>();

        foreach (Autore a in ElencoAutori)
        {
            if (a.DataDiNascita.Year == anno.Year)
            {
                annoAutori.Add(a);
            }
        }

        return annoAutori.ToArray();
    }

    public Libro[] LibroAnno(int anno)
    {
        List<Libro> AnnoLibro = new List<Libro>();

        foreach (Libro a in ElencoLibri)
        {
            if (a.Anno == anno)
            {
                AnnoLibro.Add(a);
            }
        }

        return AnnoLibro.ToArray();
    }

    public int NumeroLibri()
    {
        return ElencoLibri.Count;
    }

    public override string ToString()
    {
        return $"Biblioteca {Nome} situata in: {Indirizzo}";
    }

    // Salva i libri nel file CSV
public void SalvaCSV(string percorso)
{
    using (StreamWriter file = new StreamWriter(Path.Combine(percorso, "autori.csv")))
    {
        file.WriteLine("cognome;nome;genere;nascita");
        foreach (Autore autore in ElencoAutori)
        {
            string genere = autore.Uomo ? "M" : "F";
            file.WriteLine($"{autore.Cognome};{autore.Nome};{genere};{autore.Anno.ToShortDateString()}");
        }
    }
    using (StreamWriter file = new StreamWriter(Path.Combine(percorso, "libri.csv")))
    {
        file.WriteLine("titolo;autore;anno;pagine");
        foreach (Libro libro in ElencoLibri)
        {
            file.WriteLine($"{libro.Titolo};{libro.Autore.Cognome} {libro.Autore.Nome};{libro.Anno};{libro.Pagine}");
        }
    }
}

public void CaricaCSV(string percorso)
{
    using (StreamReader file = new StreamReader(Path.Combine(percorso, "autori.csv")))
    {
        string? lettura = file.ReadLine();
        if (lettura == null)
        {
            Console.WriteLine("Impossibile Caricare da file");
        }
        else
        {
            while (true)
            {
                lettura = file.ReadLine();
                if (lettura == null)
                    break;
                string[] pezzi = lettura.Split(';');
                string[] data = pezzi[3].Split('/');
                Autore autore = new Autore(pezzi[1], pezzi[0], new DateTime(Convert.ToInt16(data[2]), Convert.ToInt16(data[1]), Convert.ToInt16(data[0])), Convert.ToBoolean(pezzi[2]), this);
                AggiungiAutore(autore);
            }
        }
    }

    using (StreamReader file = new StreamReader(Path.Combine(percorso, "libri.csv")))
    {
        string? legi = file.ReadLine();
        while (true)
        {
            legi = file.ReadLine();
            if (legi == null)
                break;
            string[] pezzi = legi.Split(';');
            string nomeAutore = pezzi[1];
            Autore autore = ElencoAutori.FirstOrDefault(a => $"{a.Cognome} {a.Nome}" == nomeAutore);
            if (autore != null)
            {
                Libro libro = new Libro(pezzi[0], autore, Convert.ToInt32(pezzi[2]), Convert.ToInt32(pezzi[3]), this);
                AggiungiLibro(libro);
            }
        }
    }
}

}

