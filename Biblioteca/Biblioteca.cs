public class Biblioteca
{
    private string Nome;
    private string indirizzo;
    public List<Libro> ElencoLibri;
    public List<Autore> ElencoAutori;

    public Biblioteca(string NomeBiblioteca, string indirizzo)
    {
        this.Nome = NomeBiblioteca;
        this.indirizzo = indirizzo;
        this.ElencoLibri = new List<Libro>();
        this.ElencoAutori = new List<Autore>();
    }
        public void AggiungiLibro(Libro libro)
    {
        this.ElencoLibri.Add(libro);
    }


    public void AggiungiAutore(Autore autore)
    {
        this.ElencoAutori.Add(autore);
    }

    public Autore[] AutoriAnno(DateOnly anno)
    {
        List<Autore> annoAutori = new List<Autore>();
        
        foreach(Autore a in ElencoAutori)
        {
            if(a.DataDiNascita.Year == anno.Year)
            {
                annoAutori.Add(a);
            }
        }
        
        return annoAutori.ToArray();
    }
        public Libro[] LibroAnno(int anno)
    {
        List<Libro> AnnoLibro = new List<Libro>();
        
        foreach(Libro a in ElencoLibri)
        {
            if(a.Anno == anno)
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
        return $"Biblioteca {Nome} sede a: {indirizzo}";
    }
}
