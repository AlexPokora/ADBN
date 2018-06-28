using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADBN.Source;

namespace ADBN.statistics
{
    class TotalStatistic
    {
        SourceClass sc = new SourceClass();

        public int CalculateRectangle()
        {
            int? pc_Count =  sc.GetPCCount();
            int? noteBook_count = sc.GetNoteBookCount();

            //высота столба 100 едениц это максимум
            if (pc_Count>noteBook_count)
            {
                //целочисленое деление 
                return ;
            }
        }


    }
}
