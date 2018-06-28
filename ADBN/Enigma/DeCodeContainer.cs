using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADBN.Source;
using ADBN.Entity;
using System.Windows.Controls;


namespace ADBN.Enigma
{
    class DeCodeContainer
    {

        List<TextPC> textPc { get; set; } = new List<TextPC>();
        public List<TextPC> StartDeCode()
        {
        SourceClass sc = new SourceClass();
            List<PC> PcList = sc.GetPC().ToList();
            for (int i = 0; i < PcList.Count; i++)
            {
                TextPC textPCContainer = new TextPC(PcList[i]);
                textPc.Add(textPCContainer);
            }
                return textPc;
        }
    }
}
