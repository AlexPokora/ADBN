using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADBN.Source;
using System.Collections.ObjectModel;
using ADBN.Entity;
using System.ComponentModel;
using ADBN.ViewModel.Commands;

namespace ADBN.ViewModel
{
    class ADDViewModel : INotifyPropertyChanged
    {
        public ADDViewModel()
        {
            this.addDiscC = new ADDDiscCommand(this);
        }

        SourceClass sc = new SourceClass();
        public ADDDiscCommand addDiscC { get; set; }

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


        Disc _disc;
        MotherBord _motherBord;
        PowerSourse _powerSource;
        Processor _processor;
        RAM _ram;
        Soket _soket;
        VideoBord _videoCard;
        PC _pc;


        public RAM Ram
        {
            get
            {
                return _ram;
            }

            set
            {
                _ram = value;
            }
        }
        public Disc Disc
        {
            get
            {
                return _disc;
            }

            set
            {
                _disc = value;
                OnPropertyChanged("Disc");
            }
        }
        public MotherBord MotherBord
        {
            get
            {
                return _motherBord;
            }

            set
            {
                _motherBord = value;
            }
        }
        public PowerSourse PowerSource
        {
            get
            {
                return _powerSource;
            }

            set
            {
                _powerSource = value;
            }
        }
        public Processor Processor
        {
            get
            {
                return _processor;
            }

            set
            {
                _processor = value;
            }
        }
        public Soket Soket
        {
            get
            {
                return _soket;
            }

            set
            {
                _soket = value;
            }
        }
        public VideoBord VideoCard
        {
            get
            {
                return _videoCard;
            }

            set
            {
                _videoCard = value;
            }
        }
        public PC Pc
        {
            get
            {
                return _pc;
            }

            set
            {
                _pc = value;
            }
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
        public ObservableCollection<Soket> soket_Collection
        {
            get
            {
                return new ObservableCollection<Soket>(sc.GetCollectionSoket());
            }
        }
        public ObservableCollection<PC> PC_Collection
        {
            get
            {
                return new ObservableCollection<PC>(sc.GetColectionPC());
            }
        }
        public ObservableCollection<Disc> disc_Collection
        {
            get
            {
                return new ObservableCollection<Disc>(sc.GetColectionDisc());
            }
        }

        public void ADDisc()
        {
            sc.SaveDiscTable(_disc);
        }

    }
}
