using System;
using System.Collections.Generic;
using System.Text;

namespace CodiceFiscale
{
    internal class Utente
    {
        private string nome;
        private string cognome;
        private string sesso;
        private DateTime nascita;
        private string comune;
        
        public Utente() 
        {
            nome = "";
            cognome = "";
            sesso = "";
            nascita = DateTime.Now;
            comune = "";
        }

        public string getNome 
        { 
            get{ return nome; } 
            set { nome = value; } 
        }

        public string getCognome 
        { 
            get{ return cognome; } 
            set {cognome = value; } 
        }

        public string getSesso
        { 
            get{ return sesso; } 
            set {sesso = value; } 
        }

        public DateTime getNascita
        { 
            get{ return nascita; } 
            set { nascita = value; }
        }

        public string getComune
        {
            get{ return comune; }
            set { comune = value; }
        }
        public string CodiceFiscale 
        { 
            
        }

    }
}
