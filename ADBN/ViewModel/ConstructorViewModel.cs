using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADBN.Source;
using ADBN.PC_Constuctor_KIT;
using ADBN.Entity;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ADBN.ViewModel.Commands;

namespace ADBN.ViewModel
{
    class ConstructorViewModel : INotifyPropertyChanged
    {

        ConstructorComandDone ccd { get; set; }

        public ConstructorViewModel()
        {
            ccd = new ConstructorComandDone(this);
        }

        MethodVerefication mf { get; set; } = new MethodVerefication();
        SourceClass sc = new SourceClass();


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


        private RAM _ram;
        private MotherBord _motherBord;
        private Processor _processor;
        private List<Disc> _disc;
        private VideoBord _videoBord;
        private PowerSourse _powerSource;


        public MotherBord motherBord
        {
            get
            {
                return _motherBord;
            }
            set
            {
                if (value != _motherBord)
                {
                    _motherBord = value;
                    foreach (var itemProcessor in processor_Collection)
                    {
                        mf.compatibilityMotherBordToProcessor(_motherBord, itemProcessor);
                    }
                    OnPropertyChanged("processor_Collection");
                }
            }
        }
        public Processor processor
        {
            get
            {
                return _processor;
            }
            set
            {
                if (value != _processor)
                {
                    _processor = value;
                    OnPropertyChanged("motherBoard_Collection");
                }
            }
        }
        public RAM ram
        {
            get
            {
                return _ram;
            }
            set
            {
                if (value != _ram)
                {
                    _ram = value;
                    OnPropertyChanged("motherBoard_Collection");
                }
            }
        }
        public VideoBord videoBord
        {
            get
            {
                return _videoBord;
            }
            set
            {
                if (value != _videoBord)
                {
                    _videoBord = value;
                    OnPropertyChanged("videobord");
                }
            }
        }
        public PowerSourse powerSource
        {
            get { return _powerSource; }
            set
            {
                if (value != _powerSource)
                {
                    _powerSource = value;
                    OnPropertyChanged("powerSource");
                }
            }
        }
        public List<Disc> disc
        {
            get
            {
                return _disc;
            }
            set
            {
                if (value != _disc)
                {
                    _disc = value;
                    OnPropertyChanged("disc");
                }
            }
        }


        public ObservableCollection<RAM> ram_Collection
            {
                get
                {
                    if (_motherBord != null)
                    {
                        return mf.SortRAMCollection(new ObservableCollection<RAM>(sc.GetColectionRAM()), _motherBord);
                    }
                    else
                    {
                        return new ObservableCollection<RAM>(sc.GetColectionRAM());
                    }
                }
            }
        public ObservableCollection<MotherBord> motherBoard_Collection
        {
            get
            {
                if (_processor !=null)
                {
                    return mf.SortMotherBordCollection(new ObservableCollection<MotherBord>(sc.GetColectionMotherBord()),_processor);
                }
                else if (_ram !=null)
                {
                    return mf.SortMotherBordCollection(new ObservableCollection<MotherBord>(sc.GetColectionMotherBord()), _ram);
                }
                else
                {
                    return new ObservableCollection<MotherBord>(sc.GetColectionMotherBord());
                }
            }

        }
        public ObservableCollection<Processor> processor_Collection
        {
            get
            {
                if (_motherBord != null)
                {
                    return mf.SortProcessorCollection(new ObservableCollection<Processor>(sc.GetColectionProcessor()), _motherBord);
                }else
                {
                    return new ObservableCollection<Processor>(sc.GetColectionProcessor());
                }  
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
            set
            {

            }
        }

        

    }
}
