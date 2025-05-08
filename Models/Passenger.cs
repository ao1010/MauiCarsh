using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCrash.Models
{
    public class Passenger : ObservableObject
    {
        private string? _firstName;
        private string? _lastName;

        private DateTime? _time;

        private bool _absent;
        private bool _on;
        private bool _off;

        public string? First_Name
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        public string? Last_Name
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        public DateTime? Time
        {
            get { return _time; }
            set { SetProperty(ref _time, value); }
        }

        public bool Absent
        {
            get { return _absent; }
            set { SetProperty(ref _absent, value); }
        }

        public bool On
        {
            get { return _on; }
            set { SetProperty(ref _on, value); }
        }

        public bool Off
        {
            get { return _off; }
            set { SetProperty(ref _off, value); }
        }
    }
}
