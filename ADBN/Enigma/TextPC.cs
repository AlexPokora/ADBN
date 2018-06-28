using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADBN.Entity;

namespace ADBN.Enigma
{
    public class TextPC
    {

        PositionsEntities SearchDataBase = new PositionsEntities();

        public TextPC(PC Pc)
        {
            marking = Pc.Marking;
            processor = SearchingProcessor(Pc.processor_ID.Value);
            motherBord = SearchingMotherBoard(Pc.motherBord_ID.Value);
            ram = SearchingRAM(Pc.RAM_ID);
            videocard = SearchingVideoCard(Pc.videoCard_ID);
            disc1 = SearchingDisc(Pc.disc1_ID);
            disc2 = SearchingDisc(Pc.disc2_ID);
            disc3 = SearchingDisc(Pc.disc3_ID);
            disc4 = SearchingDisc(Pc.disc4_ID);
            powerSupply = SearchPowerSupply(Pc.power_Supply_ID);
            existence = Pc.existence;
            reservet = Pc.reservet;
            cost = Pc.cost;
        }
         
        public string SearchingProcessor(int processor_Id)// поиск проца
        {
            foreach (var item in SearchDataBase.Processor)
            {
                if (item.Id == processor_Id)
                {
                    return (item.manufacturer+ " " + item.model);
                }
            }
            return null;
        }
        public string SearchingMotherBoard(int MotherBoard_Id)// поиск материнской платы
        {
            foreach (var item in SearchDataBase.MotherBord)
            {
                if (item.Id == MotherBoard_Id)
                {
                    return item.name;
                }
            }
            return null;
        }
        public string SearchingRAM( int? RAM_ID)//поиск оперативной памяти
        {
            foreach (var item in SearchDataBase.RAM)
            {
                if (item.Id == RAM_ID)
                {
                    string rs = item.value.ToString() + "Gb ";
                    foreach (var DDRGeneration in SearchDataBase.MemoryGeneration)
                    {
                        if (item.DDR_generationID == DDRGeneration.Id)
                        {
                            rs = rs + DDRGeneration.Generation;
                        }
                    }
                    return rs;
                }
            }
            return null;
        }
        public string SearchingVideoCard(int? videoCard_Id)
        {
            foreach (var item in SearchDataBase.VideoBord)
            {
                if (item.Id == videoCard_Id)
                {
                    return item.model+" ("+item.memory_+"Gb /" +item.bits+"bit)";
                }
            }
            return null;
        }
        public string SearchingDisc( int? Disc_Id)
        {
            foreach (var item in SearchDataBase.Disc)
            {
                if (item.Id == Disc_Id)
                {
                    if (item.SSD == "true") 
                    {
                        return item.value.ToString() + "Gb (SSD)";
                    }
                    return item.value.ToString()+"Gb";
                }
            }
            return null;
        }
        public string SearchPowerSupply(int? PowerSupply_id)
        {
            foreach (var item in SearchDataBase.PowerSourse)
            {
                if (item.Id == PowerSupply_id)
                {
                    return item.manifacture +" "+ item.voltage.ToString();
                }
            }
            return null;
        }

        public string marking { get; set; }
        public string processor { get; set; }
        public string motherBord { get; set; }
        public string ram { get; set; }
        public string videocard { get; set; }
        public string disc1 { get; set; }
        public string disc2 { get; set; }
        public string disc3 { get; set; }
        public string disc4 { get; set; }
        public string powerSupply { get; set; }
        public int? existence { get; set; }
        public int? reservet { get; set; }
        public int? cost { get; set; }
    }
}
