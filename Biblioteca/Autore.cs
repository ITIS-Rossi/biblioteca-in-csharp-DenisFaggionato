public class Autore {
    private string Nome;
    private string Cognome;
    public DateOnly Anno;
    private bool Uomo;
    public List<Libro> Libri;

    public Autore(string NomeAutore, string CognomeAutore, DateOnly AnnoAutore, bool UomoAutore, List<Libro> Libri = null){
        this.Nome = NomeAutore;
        this.Cognome = CognomeAutore;
        this.Anno = AnnoAutore;
        this.Uomo = UomoAutore;
        this.Libri = Libri != null ? new List<Libro>(Libri) : new List<Libro>();
    }

    public int Aggiungi(Libro libroNuovo){
        this.Libri.Add(libroNuovo);
        return this.Libri.Count;
    }

    public override string ToString(){
        if(Uomo == true){
            return $"{this.Nome} {this.Cognome} nato il giorno {this.Anno} ";
        }
        else{
            return $"{this.Nome} {this.Cognome} nata il giorno {this.Anno} ";
        }
    }

    public string NomeCompleto {
        get { return $"{this.Cognome} {this.Nome}"; }
    }

    public DateOnly DataDiNascita {
        get { return this.Anno; }
    }

    public Libro[] LibriPubblicati{
        get { return this.Libri.ToArray(); }
    }
}
