using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_Notes_win.classes
{
    public static class GLOBALS
    {
        internal static ObservableCollection<_HistoryTabs> HistoryTabs = new ObservableCollection<_HistoryTabs>();
        internal static String currentTab = "HomePage";
    }
}
