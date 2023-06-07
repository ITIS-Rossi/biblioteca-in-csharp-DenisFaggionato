public class Autore {
    // LF : dovrebbero essere delle Property, non degli Attributi pubblici (NON è lo stesso!!!
    public string Nome;
    public string Cognome;
    // LF ANNO per data di nascita gestita con un DateTime ???
    public DateTime Anno;
    public bool Uomo;
    public List<Libro> Libri;

public Autore(string NomeAutore, string CognomeAutore, DateTime AnnoAutore, bool UomoAutore, Biblioteca biblioteca)
{
    this.Nome = NomeAutore;
    this.Cognome = CognomeAutore;
    this.Anno = AnnoAutore;
    this.Uomo = UomoAutore;
    this.Libri = new List<Libro>();
    biblioteca.AggiungiAutore(this);
}


    public int Aggiungi(Libro libroNuovo){
        this.Libri.Add(libroNuovo);
        return this.Libri.Count;
    }

    public override string ToString(){
        // LF : NON SERVE == true !!!!!!!!!!!!!!
        // LF 2 : NON potevi semplificare un po' ????
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

    public DateTime DataDiNascita {
        get { return this.Anno; }
    }

    public Libro[] LibriPubblicati{
        get { return this.Libri.ToArray(); }
    }
}
