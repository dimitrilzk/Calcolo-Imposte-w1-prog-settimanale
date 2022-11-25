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
        private string _dataDiNascita;
        public string DataDiNascita
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

                Console.WriteLine("\n===========================================================================");
                Console.WriteLine("Benvenuto, per calcolare le tue imposte, dovrai inserire i tuoi dati\npersonali," +
                    "a seguito della compilazione ti verra stampato il riepilogo\ncomprensivo dell'importo da pagare," +
                    "scegli l'operazione che vuoi effettuare: ");
                Console.WriteLine("===========================================================================\n");
                Console.WriteLine("1. Inizia la compilazione.");
                Console.WriteLine("2. Non voglio pagare, scappo! ");
                Console.WriteLine("3. Esci dal programma.");

                int scelta = int.Parse(Console.ReadLine());



                if (scelta == 1)
                {
                    Compilazione();
                }
                if (scelta == 2)
                {
                    Evasore();
                }
                if (scelta == 3)
                {
                    Console.WriteLine("Chiusura del programma...");
                    Environment.Exit(0);
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
        public void Compilazione()
        {
            Console.WriteLine("\nInserisci il tuo NOME: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("\nInserisci il tuo COGNOME: ");
            string Cognome = Console.ReadLine();
            Console.WriteLine("\nInserisci la tua DATA DI NASCITA in formato(GG/MM/AAAA):");
            string DataDiNascita = Console.ReadLine();
            Console.WriteLine("\nInserisci il tuo CODICE FISCALE: ");
            string CodiceFiscale = Console.ReadLine();
            Console.WriteLine("\nInserisci il tuo SESSO (m/f): ");
            string Sesso = Console.ReadLine();
            Console.WriteLine("\nInserisci il tuo COMUNE DI RESIDENZA: ");
            string ComuneDiResidenza = Console.ReadLine();
            Console.WriteLine("\nInserisci il tuo REDDITO ANNUALE: ");
            double RedditoAnnuale = double.Parse(Console.ReadLine());
            Contribuente x = new Contribuente();
            _nome = Nome;
            _cognome = Cognome;
            _dataDiNascita = DataDiNascita;
            _codiceFiscale = CodiceFiscale;
            _sesso = Sesso;
            _comuneDiResidenza = ComuneDiResidenza;
            _redditoAnnuale = RedditoAnnuale;
            double imposta23 = _redditoAnnuale * 23 / 100;
            double imposta27 = (_redditoAnnuale - 15000) * 27 / 100 + 3450;
            double imposta38 = (_redditoAnnuale - 28000) * 38 / 100 + 6960;
            
                Console.WriteLine("=================================");
                Console.WriteLine($"\nContribuente {_nome} {_cognome}");
                Console.WriteLine($"Nato il {_dataDiNascita} ({_sesso})");
                Console.WriteLine($"Residente in {_comuneDiResidenza}");
                Console.WriteLine($"Codice fiscale: {_codiceFiscale}");
                Console.WriteLine($"\nReddito dichiarato: {_redditoAnnuale}\n");
            if (_redditoAnnuale < 15000)
            {
                Console.WriteLine($"IMPOSTA DA VERSARE: {imposta23}");
                StartMenu();
            }if (_redditoAnnuale >= 15001 && _redditoAnnuale <= 28000)
            {
                Console.WriteLine($"IMPOSTA DA VERSARE: {imposta27}");
                StartMenu();
            }if (_redditoAnnuale >= 28001 && _redditoAnnuale <= 55000)
            {
                Console.WriteLine($"IMPOSTA DA VERSARE: {imposta38}");
                StartMenu();
            }
        }
    }
}
