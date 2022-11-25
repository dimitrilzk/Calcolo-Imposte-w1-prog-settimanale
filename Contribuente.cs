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
    }
}
