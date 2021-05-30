using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_Notes_win.classes
{
    class _GeneralNote
    {
        
        public string content { get; set; }
        
        public override string ToString()
        {
            //removes notes quotes and puts single quotes for sql read
            return content.ToString().Replace("'", "''");
        }

        



    }
}
