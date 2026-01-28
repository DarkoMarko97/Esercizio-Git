using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodiceFiscale
{
    internal class Utente
    {
        private string nome;
        private string cognome;
        private bool sesso;
        private DateTime nascita;
        private string comune;

        public Utente()
        {
            nome = "";
            cognome = "";
            sesso = true;
            nascita = DateTime.Now;
            comune = "";
        }

        public string getNome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string getCognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public bool getSesso
        {
            get { return sesso; }
            set { sesso = value; }
        }

        public DateTime getNascita
        {
            get { return nascita; }
            set { nascita = value; }
        }

        public string getComune
        {
            get { return comune; }
            set { comune = value; }
        }
        public string CodiceFiscale
        {
            get { return "Da implementare"; }
            set { }
        }
        

        //Qua si implementa il sistema di controllo dei nomi e quindi ogni lettera che li compone viene assegnata ad un valore
        private bool FindString(string strVal, char cVal)
        {
            foreach (char c in strVal)
            {
            if (c == cVal)
                return true;
            }
            return false;
        }

        //Mentre qua viene gestita la divisione di consonanti e vocali e come il sistema prenda le prime tre lettere di cognome e nome
        private string ExtractChars(string strVal, bool bCognome)
        {
            string retValue = "";
            string strVoc = "AaEeIiOoUu";
            int numCon = 0;
            int numVoc = 0;

            for (int i = 0; i < strVal.Length; i++)
            {
                if (!FindString(strVoc, strVal[i]) && strVal[i] != ' ')
                {
                    retValue += strVal[i];
                    ++numCon;
                }
                if (numCon >= 3) 
                {
                    if (bCognome) 
                    { 
                        break;
                    }
                    else 
                    {
                        for (int k = i; k < strVal.Length; k++) 
                        {
                            if (FindString(strVoc, strVal[k]) && strVal[k] != ' ') 
                            {
                                retValue += strVal[k];
                                string strTemp=retValue;
                                retValue = strTemp.Substring(0, 1);
                                retValue += strTemp.Substring(strTemp.Length - 2, 2);
                                i = strVal.Length;
                                break;
                            }
                        }
                    }
                }
            }
            if (numCon < 3)
            {
                for (int i = 0; i < strVal.Length; ++i)
                {
                    if (FindString(strVoc, strVal[i]))
                    {
                        retValue += strVal[i];
                        ++numVoc;
                    }
                    if ((numCon + numVoc) >= 3)
                        break;
                }
            }
            if ((numCon + numVoc) < 3)
            {
                if ((numCon + numVoc) == 0)
                    retValue = "***";
                if ((numCon + numVoc) == 1)
                    retValue = "***";
                if ((numCon + numVoc) == 2)
                    retValue += 'X';
            }
            return retValue;
        
        }

        //I mesi nel codice fiscale si convertono in una lettera in questo modo:
        //Gennaio = A, Febbraio = B, Marzo = C, Aprile = D, Maggio = E, Giugno = H,
        //Luglio = L, Agosto = M, Settembre = P, Ottobre = R, Novembre = S, Dicembre = T
        private string GetCharData()
        {
            string retVal = nascita.Year.ToString();
            retVal = retVal.Substring(2, 2);
            switch (nascita.Month)
            {
                case 1:
                    retVal += 'A';
                    break;
                case 2:
                    retVal += 'B';
                    break;
                case 3:
                    retVal += 'C';
                    break;
                case 4:
                    retVal += 'D';
                    break;
                case 5:
                    retVal += 'E';
                    break;
                case 6:
                    retVal += 'H';
                    break;
                case 7:
                    retVal += 'L';
                    break;
                case 8:
                    retVal += 'M';
                    break;
                case 9:
                    retVal += 'P';
                    break;
                case 10:
                    retVal += 'R';
                    break;
                case 11:
                    retVal += 'S';
                    break;
                case 12:
                    retVal += 'T';
                    break;
            }


            //In base al sesso dell'utente il modo in cui viene inserito il giorno di nascita varia, ovvero se l'utente è femmina va aggiunto 40
            if (sesso)
            {
                string strTemp = nascita.Day.ToString();
                if (strTemp.Length <= 1)
                {
                    retVal += "0";
                    retVal += strTemp;
                }
                else
                    retVal += strTemp;
            }
            else
                retVal += (nascita.Day + 40).ToString();

            return retVal;
        }

        private string GetCharComune(string comune)
        {
            comune = comune.Trim().ToLower();

            if (comune == "roma") 
            { return "H501"; }
            else if (comune == "milano") 
            { return "F205"; }
            else if (comune == "torino") 
            { return "L219"; }
            else if (comune == "napoli") 
            { return "F839"; }
            else if (comune == "firenze") 
            { return "D612"; }
            else if (comune == "bologna") 
            { return "A944"; }
            else if (comune == "genova") 
            { return "D969"; }
            else if (comune == "venezia") 
            { return "L736"; }
            else if (comune == "trieste") 
            { return "L424"; }
            else if (comune == "trento") 
            { return "L378"; }
            else if (comune == "bolzano") 
            { return "A952"; }
            else if (comune == "perugia") 
            { return "G478"; }
            else if (comune == "ancona") 
            { return "A271"; }
            else if (comune == "campobasso") 
            { return "B519"; }
            else if (comune == "potenza") 
            { return "G942"; }
            else if (comune == "catanzaro") 
            { return "C352"; }
            else if (comune == "aosta") 
            { return "A326"; }
            else if (comune == "bari") 
            { return "A662"; }
            else if (comune == "cagliari") 
            { return "B354"; }
            else if (comune == "palermo") 
            { return "G273"; }
            else
            { return " "; }
        }
    }
}