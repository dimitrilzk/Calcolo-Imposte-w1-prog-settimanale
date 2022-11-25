using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolo_Imposte
{
    internal class Contribuente
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _cognome;
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }
        private DateTime _dataDiNascita;
        public DateTime DataDiNascita
        {
            get { return _dataDiNascita; }
            set { _dataDiNascita = value; }
        }
        private string _codiceFiscale;
        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }
        private string _sesso;
        public string Sesso
        {
            get { return _sesso; }
            set { _sesso = value; }
        }
        private string _comuneDiResidenza;
        public string ComuneDiResidenza
        {
            get { return _comuneDiResidenza; }
            set { _comuneDiResidenza = value; }
        }
        private double _redditoAnnuale;
        public double RedditoAnnuale
        {
            get { return _redditoAnnuale; }
            set { _redditoAnnuale = value; }
        }
        public void StartMenu()
        {
            try
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("CALCOLO DELLE IMPOSTE INPS DA VERSARE");
                Console.WriteLine("*************************************");

                Console.WriteLine("\nBenvenuto, per calcolare le tue imposte, dovrai inserire i tuoi dati personali," +
                    "a seguito della compilazione ti verra stampato il riepilogo comprensivo dell'importo da pagare," +
                    "scegli l'operazione che vuoi effettuare: ");
                Console.WriteLine("1. Inizia la compilazione: ");
                Console.WriteLine("2. Non voglio pagare, scappo! ");
                //Console.WriteLine("1. Inserisci il tuo NOME: ");
                //Console.WriteLine("2. Inserisci il tuo COGNOME: ");
                //Console.WriteLine("3. Inserisci la tua DATA DI NASCITA in formato(AAAA/MM/GG):");
                //Console.WriteLine("4. Inserisci il tuo CODICE FISCALE: ");
                //Console.WriteLine("5. Inserisci il tuo SESSO (m/f): ");
                //Console.WriteLine("6. Inserisci il tuo COMUNE DI RESIDENZA: ");
                //Console.WriteLine("7. Inserisci il tuo REDDITO ANNUALE: ");
                //Console.WriteLine("8. Calcola le tue IMPOSTE: ");
                Console.WriteLine("3. ESCI");

                int scelta = int.Parse(Console.ReadLine());



                if (scelta == 1)
                {
                    //Compilazione();
                }
                if (scelta == 2)
                {
                    Evasore();
                }
                if (scelta == 3)
                {
                    Console.WriteLine("Chiusura del programma...");
                    Environment.Exit(3);
                }
                else
                {
                    Console.WriteLine("Hai selezionato una voce non valida");
                    StartMenu();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("E' successo un errore imprevisto!");
                StartMenu();
            }
        }
        public void Evasore()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("\n\n\tTI TROVEREMO!!!!!\n\n");
            Console.WriteLine("=================================");
            StartMenu();
        }
    }
}
