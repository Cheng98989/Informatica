using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hu_SimuVerifica_261018
{
    public class PartitaTorneo
    {
        private static List<string> _takenIds = new List<string>() { };
        private string _id;
        public string CodicePartita => _id;

        private string _name;
        public string NomeGioco
        {
            get { return this._name; }
            set
            {
                string v = value.Trim();
                if (string.IsNullOrEmpty(v))
                    throw new Exception("Nome gioco vuoto/nullo");
                this._name = v;
            }
        }

        private DateTime _date;
        public DateTime DataPartita
        {
            get { return this._date; }
            set
            {
                if (value.Date > DateTime.Today)
                    throw new Exception("La partita non puo' essere svolta in data futura");
                this._date = value.Date;
            }
        }

        private string _teamName1;
        public string NomeSquadra1
        {
            get { return this._teamName1; }
            set
            {
                string v = value.Trim();
                if (string.IsNullOrEmpty(v) || v == "Pareggio")
                    throw new Exception("Nome squadra 1 non puo essere vuoto/nullo om chiamata come Pareggio");
                this._teamName1 = v;
            }
        }
        private string _teamName2;
        public string NomeSquadra2
        {
            get { return this._teamName2; }
            set
            {
                string v = value.Trim();
                if (string.IsNullOrEmpty(v) || v == "Pareggio")
                    throw new Exception("Nome squadra 2 non puo essere vuoto/nullo om chiamata come Pareggio");
                this._teamName2 = v;
            }
        }

        private int _teamScore1;

        public int PunteggioSquadra1
        {
            get { return this._teamScore1; }
            set
            {
                if (value < 0)
                    throw new Exception("Punteggio squadra 1 deve essere >= 0");
                this._teamScore1 = value;
            }
        }
        private int _teamScore2;

        public int PunteggioSquadra2
        {
            get { return this._teamScore2; }
            set
            {
                if (value < 0)
                    throw new Exception("Punteggio squadra 1 deve essere >= 0");
                this._teamScore2 = value;
            }
        }

        public string SquadraVincente
        {
            get
            {
                if(this.PunteggioSquadra1 > this.PunteggioSquadra2)
                {
                    return this.NomeSquadra1;
                }
                else if (this.PunteggioSquadra1 == this.PunteggioSquadra2)
                {
                    return "Pareggio";
                }
                else
                {
                    return this.NomeSquadra2;
                }
            }
        }

        public PartitaTorneo(
            string cod,
            string nome,
            DateTime data,
            string squadra1,
            string squadra2,
            int punti1,
            int punti2)
        {
            string c = cod.Trim();
            if (string.IsNullOrEmpty(c))
                throw new Exception("Codice mancante");
            if (PartitaTorneo._takenIds.Contains(c))
                throw new Exception("Codice già occupato");
            this._id = c;
            this.NomeGioco = nome;
            this.DataPartita = data;
            this.NomeSquadra1 = squadra1;
            this.NomeSquadra2 = squadra2;
            this.PunteggioSquadra1 = punti1;
            this.PunteggioSquadra2 = punti2;

            PartitaTorneo._takenIds.Add(c);
        }

        private bool _idRemoved = false;
        public void Dispose()
        {
            if (_idRemoved)
                return;
            _takenIds.Remove(CodicePartita);
            _idRemoved = true;            
        }
    }
}
