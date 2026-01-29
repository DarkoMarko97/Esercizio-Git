// See https://aka.ms/new-console-template for more information
using CodiceFiscale;
using System.Globalization;
using System.Text;

/*
Per calcolare un codice fiscale serve prendere le prime tre lettere dal cognome, le prime tre lettere dal nome, in caso di due nomi prendere la prima e quarta lettera del primo e la prima del secondo
Poi prendere le ultime due cifre dell'anno, prendere il mese e convertirlo nella lettera corrispondente e prendere la data, fare un check del sesso, se femmina aggiungere ai giorni 40
Inserire il codice catastale e l'ultimo carattere

string codiceCatastale =;*/

Utente utente = new Utente();

utente.getNome = "Giovanni";
utente.getCognome = "Rana";
utente.getSesso = true;
utente.getNascita = DateTime.Parse("25/02/1956");
utente.getComune = "Napoli";


Console.WriteLine($"Il codice fiscale di {utente.getNome} {utente.getCognome} è {utente.CodiceFiscale}");

