using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel.Model
{
    public class Piece : INotifyPropertyChanged
    {
        private int superficie;
        private int capacite;
        private double prixJournalier;
        private bool climatisation;
        private string txtClimatisation;

        public int ID { get; set; }

        public Piece(int superficie, int capacite, double prixJournalier, bool climatisation)
        {
            this.superficie = superficie;
            this.capacite = capacite;
            this.prixJournalier = prixJournalier;
            this.climatisation = climatisation;
            this.txtClimatisation = climatisation ? "Avec" : "Sans";  
        }
        public Piece()
        {
            this.superficie = 0;
            this.capacite = 0;
            this.prixJournalier = 0.0;
            this.climatisation = false;
            this.txtClimatisation = climatisation ? "Avec" : "Sans";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public int Superficie
        {
            get
            {
                return superficie;
            }

            set
            {

                superficie = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Superficie"));
            }
        }
        public int Capacite
        {
            get
            {
                return capacite;
            }

            set
            {

                capacite = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Capacite"));
            }
        }
        public double PrixJournalier
        {
            get
            {
                return prixJournalier;
            }

            set
            {

                prixJournalier = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PrixJournalier"));
            }
        }
        public bool Climatisation
        {
            get
            {
                return climatisation;
            }

            set
            {

                climatisation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Climatisation"));
            }
        }
        public string TxtClimatisation
        {
            get
            {
                return txtClimatisation;
            }

            set
            {

                txtClimatisation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TxtClimatisation"));
            }
        }
    }
}
