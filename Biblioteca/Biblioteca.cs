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
    public void SalvaCSV (string indirizzo)
    {
        using (StreamWriter file = new StreamWriter(Path.Combine(indirizzo, "autori.csv")))
        {
            file.WriteLine("Cognome dell'autore;Nome dell'autore;Uomo?;Data di Nascita");
            foreach (Autore autore in ElencoAutori)
            {
                file.WriteLine($"{autore.Cognome};{autore.Nome};{autore.Uomo};{autore.Anno}");
            }
        }
        using (StreamWriter file = new StreamWriter(Path.Combine(indirizzo, "libri.csv")))
        {
            file.WriteLine("Titolo del libro;Autore del libro;Anno di pubblicazione; Pagine ");
            foreach (Libro libro in ElencoLibri)
            {
                file.WriteLine($"{libro.Titolo};{libro.Autore};{libro.Anno};{libro.Pagine}");
            }
        }
    }
    public void CaricaCSV (string indirizzo)
    {
        using (StreamReader file = new StreamReader(Path.Combine(indirizzo, "autori.csv")))
        {
            string? lettura = file.ReadLine();
  
            while(true)
            {
                //Console.WriteLine("UUUUUUUUUUUUUU");
                lettura = file.ReadLine();
                if(lettura == null)
                    break;
                string[] pezzi = lettura.Split(';');
                string[] data = pezzi[3].Split('/');
                Autore autore = new Autore(pezzi[1], pezzi[0], new DateTime(Convert.ToInt16(data[2]), Convert.ToInt16(data[1]), Convert.ToInt16(data[0])), Convert.ToBoolean(pezzi[2]), this);
            }
        
        }
        using (StreamReader file = new StreamReader(Path.Combine(indirizzo, "libri.csv")))
        {
        string? lettura = file.ReadLine();
            while(true)
            {
                lettura = file.ReadLine();
                if(lettura == null)
                    break;
                string[] pezzi = lettura.Split(';');
                foreach(Autore autore in ElencoAutori)
                {
                    if(pezzi[1] == ($"{autore.Cognome} {autore.Nome}"))
                    {
                        Libro libro = new Libro(pezzi[0], autore, (Convert.ToInt16(pezzi[2])), (Convert.ToInt16(pezzi[3])), this);
                        break;
                    }
                }
            }
        }
    }

}

