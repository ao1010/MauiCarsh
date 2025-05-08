using CommunityToolkit.Mvvm.ComponentModel;
using MauiCrash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCrash.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private enum SortOrder
        {
            FirstName,
            LastName,
            Time
        };

        private SortOrder _sortOrder = SortOrder.FirstName;

        private List<Passenger> _passengers;

        public List<Passenger> Passengers
        {
            get { return _passengers; }
            set { SetProperty(ref _passengers, value); }
        }

        private Passenger _selectedItem;

        public Passenger SelectedItem
        {
            get { return _selectedItem; }
            set { SetProperty(ref _selectedItem, value); }
        }

        public MainPageViewModel()
        {
            _passengers = new List<Passenger>();

            _passengers.Add(new Passenger { First_Name = "Aaaaaaa", Last_Name = "Zzzzzzzz", Time = DateTime.Today.AddMinutes(10) });
            _passengers.Add(new Passenger { First_Name = "Baaaaaa", Last_Name = "Yzzzzzzz", Time = DateTime.Today.AddMinutes(20) });
            _passengers.Add(new Passenger { First_Name = "Caaaaaa", Last_Name = "Xzzzzzzz", Time = DateTime.Today.AddMinutes(1) });
            _passengers.Add(new Passenger { First_Name = "Daaaaaa", Last_Name = "Wzzzzzzz", Time = DateTime.Today.AddMinutes(5) });
            _passengers.Add(new Passenger { First_Name = "Eaaaaaa", Last_Name = "Vzzzzzzz", Time = DateTime.Today.AddMinutes(2) });
            _passengers.Add(new Passenger { First_Name = "Faaaaaa", Last_Name = "Uzzzzzzz", Time = DateTime.Today.AddMinutes(13) });
            _passengers.Add(new Passenger { First_Name = "Gaaaaaa", Last_Name = "Tzzzzzzz", Time = DateTime.Today.AddMinutes(15) });
            _passengers.Add(new Passenger { First_Name = "Haaaaaa", Last_Name = "Szzzzzzz", Time = DateTime.Today.AddMinutes(11) });
            _passengers.Add(new Passenger { First_Name = "Iaaaaaa", Last_Name = "Rzzzzzzz", Time = DateTime.Today.AddMinutes(12) });
            _passengers.Add(new Passenger { First_Name = "Jaaaaaa", Last_Name = "Qzzzzzzz", Time = DateTime.Today.AddMinutes(19) });
            _passengers.Add(new Passenger { First_Name = "Kaaaaaa", Last_Name = "Pzzzzzzz", Time = DateTime.Today.AddMinutes(18) });
            _passengers.Add(new Passenger { First_Name = "Laaaaaa", Last_Name = "Ozzzzzzz", Time = DateTime.Today.AddMinutes(17) });
            _passengers.Add(new Passenger { First_Name = "Maaaaaa", Last_Name = "Nzzzzzzz", Time = DateTime.Today.AddMinutes(2) });
            _passengers.Add(new Passenger { First_Name = "Naaaaaa", Last_Name = "Mzzzzzzz", Time = DateTime.Today.AddMinutes(3) });
            _passengers.Add(new Passenger { First_Name = "Oaaaaaa", Last_Name = "Lzzzzzzz", Time = DateTime.Today.AddMinutes(10) });
            _passengers.Add(new Passenger { First_Name = "Paaaaaa", Last_Name = "Kzzzzzzz", Time = DateTime.Today.AddMinutes(5) });
            _passengers.Add(new Passenger { First_Name = "Qaaaaaa", Last_Name = "Jzzzzzzz", Time = DateTime.Today.AddMinutes(7) });
            _passengers.Add(new Passenger { First_Name = "Raaaaaa", Last_Name = "Izzzzzzz", Time = DateTime.Today.AddMinutes(18) });
            _passengers.Add(new Passenger { First_Name = "Saaaaaa", Last_Name = "Hzzzzzzz", Time = DateTime.Today.AddMinutes(14) });
            _passengers.Add(new Passenger { First_Name = "Taaaaaa", Last_Name = "Gzzzzzzz", Time = DateTime.Today.AddMinutes(12) });
            _passengers.Add(new Passenger { First_Name = "Uaaaaaa", Last_Name = "Fzzzzzzz", Time = DateTime.Today.AddMinutes(16) });
            _passengers.Add(new Passenger { First_Name = "Vaaaaaa", Last_Name = "Ezzzzzzz", Time = DateTime.Today.AddMinutes(17) });
            _passengers.Add(new Passenger { First_Name = "Waaaaaa", Last_Name = "Dzzzzzzz", Time = DateTime.Today.AddMinutes(19) });
            _passengers.Add(new Passenger { First_Name = "Xaaaaaa", Last_Name = "Czzzzzzz", Time = DateTime.Today.AddMinutes(11) });
            _passengers.Add(new Passenger { First_Name = "Yaaaaaa", Last_Name = "Bzzzzzzz", Time = DateTime.Today.AddMinutes(1) });
            _passengers.Add(new Passenger { First_Name = "Zaaaaaa", Last_Name = "Azzzzzzz", Time = DateTime.Today.AddMinutes(10) });

            _selectedItem = _passengers.First();

            Application.Current.Dispatcher.StartTimer(TimeSpan.FromMilliseconds(5000), () => CrashApp());
        }

        private bool CrashApp()
        {
            switch (_sortOrder)
            {
                case SortOrder.Time:
                {
                    _sortOrder = SortOrder.FirstName;
                    break;
                }
                case SortOrder.FirstName:
                {
                    _sortOrder = SortOrder.LastName;
                    break;
                }
                case SortOrder.LastName:
                {
                    _sortOrder = SortOrder.Time;
                    break;
                }
            }

            SortPassengers();

            Random rand = new Random((int)DateTime.Now.Ticks);

            int number = rand.Next(Passengers.Count);

            Passengers[number].Absent = !Passengers[number].Absent;

            SelectedItem = Passengers[number];

            return true;
        }

        private void SortPassengers()
        {
            switch (_sortOrder)
            {
                case SortOrder.FirstName:
                {
                    Passengers = Passengers.OrderBy(x => x.First_Name).ToList();
                    break;
                }
                case SortOrder.LastName:
                {
                    Passengers = Passengers.OrderBy(x => x.Last_Name).ToList();
                    break;
                }
                case SortOrder.Time:
                {
                    Passengers = Passengers.OrderBy(x => x.Time).ToList();
                    break;
                }
            }
        }
    }
}
