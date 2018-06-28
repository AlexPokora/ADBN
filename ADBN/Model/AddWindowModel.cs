using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADBN.Source;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ADBN.Entity;
using ADBN.ViewModel.Commands;

namespace ADBN.Model
{
    class AddWindowModel : INotifyPropertyChanged
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

        SourceClass sc = new SourceClass();


        public AddWindowModel()
        {
            ld = new LoadInDataBaseCommand(this);
        }

        public ObservableCollection<RAM> ram_Collection
        {
            get
            {
                    return new ObservableCollection<RAM>(sc.GetColectionRAM());
            }
        }
        public ObservableCollection<MotherBord> motherBoard_Collection
        {
            get
            {
                    return new ObservableCollection<MotherBord>(sc.GetColectionMotherBord());
            }

        }
        public ObservableCollection<Processor> processor_Collection
        {
            get
            {
                    return new ObservableCollection<Processor>(sc.GetColectionProcessor());
            }
        }
        public ObservableCollection<VideoBord> videoBord_Collection
        {
            get
            {
                return new ObservableCollection<VideoBord>(sc.GetColectionVideoBord());
            }
        }
        public ObservableCollection<PowerSourse> powerSource_Collection
        {
            get
            {
                return new ObservableCollection<PowerSourse>(sc.GetColectionPowerSource());
            }
        }
        public ObservableCollection<Disc> disc_Collection
        {
            get
            {
                return new ObservableCollection<Disc>(sc.GetColectionDisc());
            }
        }
        public ObservableCollection<PC> pc_Collection
        {
            get
            {
                return new ObservableCollection<PC>(sc.GetColectionPC());
            }
        }
        public ObservableCollection<Soket> soket_Collection
        {
            get
            {
                return new ObservableCollection<Soket>(sc.GetColectionSoket());
            }
        }


        public Disc SelectedDisc
        {
            get
            {
                return _selectedDisc;
            }

            set
            {
                if (_selectedDisc!=value)
                {
                    _selectedDisc = value;
                    OnPropertyChanged("SelectedDisc"); 
                }
            }
        }
        public PowerSourse SelectedPowerSourse
        {
            get => _selectedPowerSourse; set
            {
                if (_selectedPowerSourse != value)
                {
                    _selectedPowerSourse = value;
                    OnPropertyChanged("SelectedPowerSourse");
                }
            }
        }
        public MotherBord SelectedMotherBord
        {
            get => _selectedMotherBord;
            set
            {
                if (_selectedMotherBord != value)
                {
                    _selectedMotherBord = value;
                    OnPropertyChanged("SelectedMotherBord");
                }
            }
        }
        public Processor SelectedProcesor
        {
            get => _selectedProcessor;
            set
            {
                if (_selectedProcessor != value)
                {
                    _selectedProcessor = value;
                    OnPropertyChanged("SelectedProcesor");
                }
            }
        }
        public VideoBord SelectedVideoBord
        {
            get => _selectedVideoBord;
            set
            {
                if (_selectedVideoBord != value)
                {
                    _selectedVideoBord = value;
                    OnPropertyChanged("SelectedVideoBord");
                }
            }
        }
        public RAM SelectedRAM
        {
            get => _selectedRAM;
            set
            {
                if (_selectedRAM != value)
                {
                    _selectedRAM = value;
                    OnPropertyChanged("SelectedRAM");
                }
            }
        }
        public Soket SelectedSoket
        {
            get => _selectedSoket;
            set
            {
                if (_selectedSoket != value)
                {
                    _selectedSoket = value;
                    OnPropertyChanged("SelectedSoket");
                }
            }
        }


        private Disc _selectedDisc;
        private PowerSourse _selectedPowerSourse;
        private MotherBord _selectedMotherBord;
        private Processor _selectedProcessor;
        private VideoBord _selectedVideoBord;
        private RAM _selectedRAM;
        private Soket _selectedSoket;


        public LoadInDataBaseCommand ld { get; set; }

        public void AddDisc()
        {
            sc.AddNewDisc(_selectedDisc);
            OnPropertyChanged("disc_Collection");
        }
        

    }
}
