using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADBN.Enigma;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ADBN
{
    class MainWindowModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        public void RepeatMainTable()
        {
            textPc = IDToText.StartDeCode();
        }
        List<TextPC> textPc { get; set; }  = new List<TextPC>();
        DeCodeContainer IDToText = new DeCodeContainer();
        public ObservableCollection<TextPC> ListVeiw
        {
            get
            {
                return new ObservableCollection<TextPC>(IDToText.StartDeCode());
            }
        }

        

        private int _MFR1;
        private int _MFR2;
        private int _MFR3;

        public int MFR1
        {
            get => _MFR1;
            set
            {
                if (_MFR1 != value)
                {
                    _MFR1 = value;
                    OnPropertyChanged("_MFR1");
                }
            }
        }
        public int MFR2
        {
            get => _MFR2;
            set
            {
                if (_MFR2 != value)
                {
                    _MFR2 = value;
                    OnPropertyChanged("_MFR2");
                }
            }
        }
        public int MFR3
        {
            get => _MFR3;
            set
            {
                if (_MFR3 != value)
                {
                    _MFR3 = value;
                    OnPropertyChanged("_MFR3");
                }
            }
        }

    }
}
