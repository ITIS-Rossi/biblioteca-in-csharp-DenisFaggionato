public class Libro
{
    public string Titolo;
    public Autore Autore;
    public int Anno;
    public int Pagine;
    public int TotalePrestiti;
    public Biblioteca Biblioteca;

    public Libro(string TitoloLibro, Autore AutoreLibro, int AnnoLibro, int NumPagine, Biblioteca biblioteca)
    {
        this.Titolo = TitoloLibro;
        this.Autore = AutoreLibro;
        this.Anno = AnnoLibro;
        this.Pagine = NumPagine;
        this.TotalePrestiti = 0;
        this.Biblioteca = biblioteca;

        
        biblioteca.AggiungiLibro(this);
    }

    public override string ToString()
    {
        return $"'{this.Titolo}' pubblicato nel {this.Anno}, Prestiti totali: {this.TotalePrestiti}";
    }
}
