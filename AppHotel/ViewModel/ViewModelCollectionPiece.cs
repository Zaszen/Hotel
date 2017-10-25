using AppHotel.Model;
using AppHotel.CodeFirst;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AppHotel.ViewModel
{
    public class ViewModelCollectionPiece
    {
        private HotelContext context;
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

        public void listePiece_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e);
        }
        public List<Piece> lstPiece { get; set; }
        private ObservableCollection<Piece> hotel;

        public ObservableCollection<Piece> Hotel
        {
            get
            {
                return hotel;
            }

            set
            {
                hotel = value;
                NotifyPropertyChanged();
            }
        }

        private Piece tempPiece = new Piece();
        public Piece TempPiece
        {
            get
            {
                return tempPiece;
            }

            set
            {

                tempPiece = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TempPiece"));
            }
        }

        private Piece selectedItem;
        public Piece SelectedItem{

            get
            {
                return selectedItem;
            }

            set
            {

                selectedItem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedItem"));
            }
        }

        public ViewModelCollectionPiece()
        {
            Hotel = new ObservableCollection<Piece>();
            context = new HotelContext();
            getAllBdd();
        }

        private void getAllBdd()
        {
            var query = (from a in context.EntityPiece select a).ToList();
            this.lstPiece = query;
            Hotel = new ObservableCollection<Piece>(lstPiece as List<Piece>);
        }

        private ICommand ajoutPiece;
        public ICommand AjoutPiece
        {
            get
            {
                if (ajoutPiece == null)
                {

                    ajoutPiece = new RelayCommand<object>((obj) => {
                        int s = TempPiece.Superficie;
                        int c = TempPiece.Capacite;
                        double p = tempPiece.PrixJournalier;
                        bool cl = tempPiece.Climatisation;
                        Hotel.Add(new Piece(s, c, p, cl));
                        context.EntityPiece.Add(new Piece(s, c, p, cl));
                        context.SaveChanges();
                    });

                }
                return ajoutPiece;
            }

        }

        private ICommand suprimmerPiece;
        public ICommand SuprimmerPiece
        {
            get
            {


                suprimmerPiece = new RelayCommand<Piece>((obj) =>
                {
                    context.EntityPiece.Remove(obj);
                    context.SaveChanges();
                    Hotel.Remove(obj);
                });


                return suprimmerPiece;
            }
        }

        private ICommand editerPiece;
        public ICommand EditerPiece
        {
            get
            {
                editerPiece = new RelayCommand<Piece>((obj) =>
                {
                    if(obj != null && SelectedItem != null)
                    {
                        var original = context.EntityPiece.Find(SelectedItem.ID);
                        if(original != null)
                        {
                            obj.ID = SelectedItem.ID;
                            TempPiece.ID = SelectedItem.ID;
                            context.Entry(SelectedItem).CurrentValues.SetValues(TempPiece);
                            context.SaveChanges();
                        }
                    }
                });


                return editerPiece;
            }
        }
        //private ICommand editerPiece;
        //public ICommand EditerPiece
        //{
        //    get
        //    {
        //        if (editerPiece == null)
        //        {
        //            editerPiece = new RelayCommand<Piece>((p) => TempPiece = p);
        //        }
        //        return editerPiece;
        //    }

        //}

    }
}
