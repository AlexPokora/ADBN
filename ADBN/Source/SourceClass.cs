using System.Linq;
using ADBN.Entity;
using System.Windows.Controls;
using ADBN.Enigma;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ADBN.Source
{
    public class SourceClass
    {
        PositionsEntities DataBase = new PositionsEntities();
        public void MainTableBiding(DataGrid dg)
        {
            //dg.DataContext = GetPC().ToList();
            dg.DataContext = GetPC().ToList();
        }

        public ObservableCollection<PC> GetColectionPC()//Pc
        {
            return new ObservableCollection<PC>(GetPC().ToList());
        }
        public ObservableCollection<MotherBord> GetColectionMotherBord()//MotherBord
        {
            return new ObservableCollection<MotherBord>(GetMotherBoard().ToList());
        }
        public ObservableCollection<RAM> GetColectionRAM()
        {
            return new ObservableCollection<RAM>(GetRAM().ToList());
        }
        public ObservableCollection<Processor> GetColectionProcessor()
        {
            return new ObservableCollection<Processor>(GetProcessor().ToList());
        }
        public ObservableCollection<VideoBord> GetColectionVideoBord()
        {
            return new ObservableCollection<VideoBord>(GetVideoCard().ToList());
        }
        public ObservableCollection<PowerSourse> GetColectionPowerSource()
        {
            return new ObservableCollection<PowerSourse>(GetPowerSource().ToList());
        }
        public ObservableCollection<Disc> GetColectionDisc()
        {
            return new ObservableCollection<Disc>(GetDisc().ToList());
        }
        public ObservableCollection<Soket> GetColectionSoket()
        {
            return new ObservableCollection<Soket>(GetSoket().ToList());
        }

        public int? GetPCCount()//возврощяет имеющиеся количество компьютеров
        {
            int? count = new int?();
            foreach (var item in DataBase.PC)
            {
                count=item.existence - item.reservet;
            }
            return count;
        }

        public int? GetNoteBookCount()
        {
            int? count = new int?();
            foreach (var item in DataBase.NoteBook)
            {
                count = item.existence - item.reservet;
            }
            return count;
        }


        public void SoketTableBinding(DataGrid dg)
        {
            dg.DataContext = GetSoket().ToList();
        }
        public void SaveSocket(DataGrid dg)
        {
            if (dg.SelectedCells != null)
            {
            DataBase.SoketSet.Add((Soket)dg.SelectedItem);
            DataBase.SaveChanges();
            dg.DataContext = GetSoket().ToList();
            }
        }
        public void EditSoket(int? SoketId)
        {
            Soket soket = DataBase.SoketSet.Where(c => c.Id == c.Id).FirstOrDefault();//узнать что это за строка
            if (soket != null)
            {
                DataBase.Entry<Soket>(soket).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
            }
        }
        public IQueryable<Soket> GetSoket()
        {
            return DataBase.SoketSet.AsQueryable<Soket>();
        }

        public void PCTableBiding(DataGrid dg)
        {
            dg.DataContext = GetPC().ToList();
        }
        public void SavePCTable(DataGrid dg)
        {
            if (dg.SelectedItem != null)
            {
                DataBase.PC.Add((PC)dg.SelectedItem);
                DataBase.SaveChanges();
                dg.DataContext = GetPC().ToList();
            }
        }
        public void EditPC(int? PC_Id)// редактирование
        {
            PC pc = DataBase.PC.Where(c => c.Id == c.Id).FirstOrDefault();//узнать что это за строка
            if (pc != null)
            {
                DataBase.Entry<PC>(pc).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
            }
        }
        public IQueryable<PC> GetPC()
        {
            return DataBase.PC.AsQueryable<PC>();
        }

        public void DeliteDisc(DataGrid dg)//удаление
        {
            DataBase.Disc.Local.Remove((Disc)dg.SelectedItem);
            //DataBase.Entry<Disc>(disc).State = System.Data.Entity.EntityState.Deleted;
            DataBase.SaveChanges();
            DiscTableBiding(dg);
        }
        public void DiscTableBiding(DataGrid dg)
        {
            dg.DataContext = GetDisc().ToList();
        }
        public void SaveDiscTable(DataGrid dg)
        {
            DataBase.Disc.Add((Disc)dg.SelectedItem);
            DataBase.SaveChanges();
            dg.DataContext = GetDisc().ToList();
        }
        public void EditDisc(int? discID)// редактирование
        {
            Disc disc = DataBase.Disc.Where(c => c.Id == c.Id).FirstOrDefault();//узнать что это за строка
            if (disc != null)
            {
                DataBase.Entry<Disc>(disc).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
            }
        }
        public IQueryable<Disc> GetDisc()
        {
            return DataBase.Disc.AsQueryable<Disc>();
        }
        public void AddNewDisc(Disc disc)
        {
            if (disc != null)
            {
                DataBase.Disc.Add(disc);
                DataBase.SaveChanges();
            }
        }


        public void MotherBoardTableBiding(DataGrid dg)
        {
            dg.DataContext = GetMotherBoard().ToList();
        }
        public void SaveMotherBoardTable(DataGrid dg)
        {
            DataBase.MotherBord.Add((MotherBord)dg.SelectedItem);
            DataBase.SaveChanges();
            dg.DataContext = GetDisc().ToList();
        }
        public void EditMotherBoard(int? MotherBoardID)// редактирование
        {
            MotherBord motherBoard = DataBase.MotherBord.Where(c => c.Id == c.Id).FirstOrDefault();//узнать что это за строка
            if (motherBoard != null)
            {
                DataBase.Entry<MotherBord>(motherBoard).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
            }
        }
        public IQueryable<MotherBord> GetMotherBoard()
        {
            return DataBase.MotherBord.AsQueryable<MotherBord>();
        }


        public void PowerSourceTableBiding(DataGrid dg)
        {
            dg.DataContext = GetPowerSource().ToList();

        }
        public void SavePowerSourceTable(DataGrid dg)
        {
            DataBase.PowerSourse.Add((PowerSourse)dg.SelectedItem);
            DataBase.SaveChanges();
            dg.DataContext = GetDisc().ToList();
        }
        public void EditPowerSource(int? MotherBoardID)// редактирование
        {
            PowerSourse powerSource = DataBase.PowerSourse.Where(c => c.Id == c.Id).FirstOrDefault();//узнать что это за строка
            if (powerSource != null)
            {
                DataBase.Entry<PowerSourse>(powerSource).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
            }
        }
        public IQueryable<PowerSourse> GetPowerSource()
        {
            return DataBase.PowerSourse.AsQueryable<PowerSourse>();
        }

        public void ProcessorTableBiding(DataGrid dg)
        {
            dg.DataContext = GetProcessor().ToList();

        }
        public void SaveProcessorTable(DataGrid dg)
        {
            DataBase.Processor.Add((Processor)dg.SelectedItem);
            DataBase.SaveChanges();
            dg.DataContext = GetDisc().ToList();
        }
        public void EditProcessor(int? ProcessorID)// редактирование
        {
            Processor processor = DataBase.Processor.Where(c => c.Id == c.Id).FirstOrDefault();//узнать что это за строка
            if (processor != null)
            {
                DataBase.Entry<Processor>(processor).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
            }
        }
        public IQueryable<Processor> GetProcessor()
        {
            return DataBase.Processor.AsQueryable<Processor>();
        }

        public void RAMTableBiding(DataGrid dg)
        {
            dg.DataContext = GetRAM().ToList();

        }
        public void SaveRAMTable(DataGrid dg)
        {
            DataBase.RAM.Add((RAM)dg.SelectedItem);
            DataBase.SaveChanges();
            dg.DataContext = GetDisc().ToList();
        }
        public void EditRAM(int? RAMID)// редактирование
        {
            RAM ram = DataBase.RAM.Where(c => c.Id == c.Id).FirstOrDefault();//узнать что это за строка
            if (ram != null)
            {
                DataBase.Entry<RAM>(ram).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
            }
        }
        public IQueryable<RAM> GetRAM()
        {
            return DataBase.RAM.AsQueryable<RAM>();
        }

        public void VideoCardTableBiding(DataGrid dg)
        {
            dg.DataContext = GetVideoCard().ToList();
        }
        public void SaveVideoCardTable(DataGrid dg)
        {
            DataBase.VideoBord.Add((VideoBord)dg.SelectedItem);
            DataBase.SaveChanges();
            dg.DataContext = GetDisc().ToList();
        }
        public void EditVideoCard(int? VideoBordID)// редактирование
        {
            VideoBord videoBord = DataBase.VideoBord.Where(c => c.Id == c.Id).FirstOrDefault();//узнать что это за строка
            if (videoBord != null)
            {
                DataBase.Entry<VideoBord>(videoBord).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
            }
        }
        public IQueryable<VideoBord> GetVideoCard()
        {
            return DataBase.VideoBord.AsQueryable<VideoBord>();
        }

    }
}
