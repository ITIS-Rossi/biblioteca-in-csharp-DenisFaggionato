public class Libro {

    private string Titolo;
    private Autore Autore;
    private int Anno;
    private int pagine;

    public Libro(string TitoloLibro, Autore AutoreLibro, int AnnoLibro, int NumPagine){
        AutoreLibro.Aggiungi(this);
        this.Titolo = TitoloLibro;
        this.Autore = AutoreLibro;
        this.Anno = AnnoLibro;
        this.pagine = NumPagine;
    }

    public override string ToString(){
        
        return $"'{this.Titolo}' pubblicato nel {this.Anno}";
    }
    

}