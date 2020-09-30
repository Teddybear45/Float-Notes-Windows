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
        private int cHeight;
        private int cWidth; 
        
        public string content { get; set; }

        public override string ToString()
        {
            //removes notes quotes and puts single quotes for sql read
            return content.ToString().Replace("'", "''");
        }

        public int update_cHeight ()
        {
            int numLines = content.Split('\n').Length;
            Trace.WriteLine("numlines: " + numLines);
            return numLines * 20;
        }



    }
}
