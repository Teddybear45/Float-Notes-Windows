using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Float_Notes_win.classes
{
    public static class GLOBALS
    {
        //history
        internal static ObservableCollection<_HistoryTabs> HistoryTabs = new ObservableCollection<_HistoryTabs>();
        internal static String currentTab = "HomePage";

        //tasks
        internal static ObservableCollection<_TaskItem> Tasks = new ObservableCollection<_TaskItem>();

        //tags
        internal static ObservableCollection<_TagItem> Tags = new ObservableCollection<_TagItem>();
        
    }

    
}
