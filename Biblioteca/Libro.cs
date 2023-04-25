public class Libro {

    private string Titolo;
    private string Autore;
    private int Anno;
    private int pagine;

    public Libro(string TitoloLibro, string AutoreLibro, int AnnoLibro, int NumPagine){
        this.Titolo = TitoloLibro;
        this.Autore = AutoreLibro;
        this.Anno = AnnoLibro;
        this.pagine = NumPagine;
    }

    public string info(){
        return $"{this.Titolo} di {this.Autore} (Anno {this.Anno})";
    }
}