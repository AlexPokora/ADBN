using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADBN.Source;
using ADBN.Entity;
using System.Collections.ObjectModel;

namespace ADBN.PC_Constuctor_KIT
{
    class MethodVerefication//класс с методами проверки и сравнений 
    {
        public bool compatibilityMotherBordToRAM(MotherBord m, RAM r)//сравнение памяти и матери
        {
            if (m.MemoryGeneration == r.MemoryGeneration)
            {
                return true;
            }
            return false;
        }
        public bool compatibilityMotherBordToProcessor(MotherBord m, Processor p)//сравнения матери и проца
        {
            if (m.SoketId == p.SoketId)
            {
                return true;
            }
            return false;
        }

        public ObservableCollection<MotherBord> SortMotherBordCollection(ObservableCollection<MotherBord> instantCollection, Processor selectedProcessor)
        {
            ObservableCollection<MotherBord> r= new ObservableCollection<MotherBord>();
            foreach (var item in instantCollection)
            {
                if (compatibilityMotherBordToProcessor(item,selectedProcessor))
                {
                    r.Add(item);
                }
            }
            return r;
        }
        public ObservableCollection<MotherBord> SortMotherBordCollection(ObservableCollection<MotherBord> instantCollection, RAM selectedRAM)
        {
            ObservableCollection<MotherBord> r = new ObservableCollection<MotherBord>();
            foreach (var item in instantCollection)
            {
                if (compatibilityMotherBordToRAM(item, selectedRAM))
                {
                    r.Add(item);
                }
            }
            return r;
        }
        public ObservableCollection<Processor> SortProcessorCollection(ObservableCollection<Processor> instantCollection, MotherBord selectedMotherBord)
        {
            ObservableCollection<Processor> r = new ObservableCollection<Processor>();
            foreach (var item in instantCollection)
            {
                if (compatibilityMotherBordToProcessor(selectedMotherBord, item))
                {
                    r.Add(item);
                }
            }
            return r;
        }
        public ObservableCollection<RAM> SortRAMCollection(ObservableCollection<RAM> instantCollection, MotherBord selectedMotherBord)
        {
            ObservableCollection<RAM> r = new ObservableCollection<RAM>();
            foreach (var item in instantCollection)
            {
                if (compatibilityMotherBordToRAM(selectedMotherBord, item))
                {
                    r.Add(item);
                }
            }
            return r;
        }

    }
}
