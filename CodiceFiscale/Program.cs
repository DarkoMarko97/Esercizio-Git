// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;

Console.WriteLine("Ciao, sono un calcolatore di codici fiscali! Mi servono il nome, il cognome, il sesso, la data di nascita e il comune, inseriscili per favore!");
Console.WriteLine("Inserisci il nome: ");
string nome = Console.ReadLine()?.ToUpper();
Console.WriteLine("Inserisci il cognome: ");
string cognome = Console.ReadLine()?.ToUpper();
Console.WriteLine("Inserisci il sesso: ");
string sesso = Console.ReadLine()?.ToUpper();
Console.WriteLine("Inserisci la data di nascita (il formato è dd/MM/yyyy): ");
string dataNascita = Console.ReadLine();
string format = "dd/MM/yyyy";
CultureInfo region = new CultureInfo("it-IT");
DateTime nascita = DateTime.ParseExact(dataNascita, format,region);
Console.WriteLine("Inserisci il comune di nascita: ");
string comune = Console.ReadLine();

//Per calcolare un codice fiscale serve prendere le prime tre lettere dal cognome, le prime tre lettere dal nome, in caso di due nomi prendere la prima e quarta lettera del primo e la prima del secondo
//Poi prendere le ultime due cifre dell'anno, prendere il mese e convertirlo nella lettera corrispondente e prendere la data, fare un check del sesso, se femmina aggiungere ai giorni 40
//Inserire il codice catastale e l'ultimo carattere

int giorno = nascita.Day;
int mese = nascita.Month;
int anno = nascita.Year % 100;

if  (sesso == "FEMMINA" || sesso == "F" || sesso == "DONNA") 
{
    giorno += 40;
    giorno=giorno.ToString();

}

//I mesi nel codice fiscale si convertono in una lettera in questo modo:
//Gennaio = A, Febbraio = B, Marzo = C, Aprile = D, Maggio = E, Giugno = H,
//Luglio = L, Agosto = M, Settembre = P, Ottobre = R, Novembre = S, Dicembre = T
char meseCodice;
switch(mese.ToString()) 
{
    case 1: meseCodice = 'A';
        break;
    case 2: meseCodice = 'B';
        break;
    case 3: meseCodice = 'C';
        break;
    case 4:
        meseCodice = 'D';
        break;
    case 5:
        meseCodice = 'E';
        break;
    case 6:
        meseCodice = 'H';
        break;
    case 7:
        meseCodice = 'L';
        break;
    case 8:
        meseCodice = 'M';
        break;
    case 9:
        meseCodice = 'P';
        break;
    case 10:
        meseCodice = 'R';
        break;
    case 11:
        meseCodice = 'S';
        break;
    case 12:
        meseCodice = 'T';
        break;
}

string lettereCognome =;
string lettereNome =;
string codiceCatastale =;

public string CF(string cognome, string nome, int anno, int giorno, string comune) 
{
    return lettereCognome + lettereNome + anno.ToString()+ mese + giorno + comune;
}
