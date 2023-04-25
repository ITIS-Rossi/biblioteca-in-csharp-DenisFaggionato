public class Autore {

    private string Nome;
    private string Cognome;
    private DateOnly Anno;
    private Boolean Uomo;
    private string[] Libri;

    public Autore(string NomeAutore, string CognomeAutore, DateOnly AnnoAutore, Boolean UomoAutore){
        this.Nome = NomeAutore;
        this.Cognome = CognomeAutore;
        this.Anno = AnnoAutore;
        this.Uomo = UomoAutore;
    }

    public override string ToString(){
        if(Uomo == true){
            return $"{this.Nome} {this.Cognome} nato il giorno {this.Anno}";
        }
        else{
            return $"{this.Nome} {this.Cognome} nata il giorno {this.Anno}";

        }

    }
}