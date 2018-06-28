using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADBN.Entity;


namespace ADBN.PC_Constuctor_KIT
{
    class FragmentContainer
    {
        PC pc { get; set; }
        MotherBord motherBord { get; set; }
        Processor processor { get; set; }
        List<Disc> disc { get; set; }
        RAM ram  { get; set; }
        VideoBord videoBoard { get; set; }



    }
}
