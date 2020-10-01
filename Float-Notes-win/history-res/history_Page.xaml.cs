using Float_Notes_win._classes;
using Float_Notes_win.classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Float_Notes_win.sub_content
{
	/// <summary>
	/// Interaction logic for history_page.xaml
	/// </summary>
	public partial class history_page : Page
	{

		private int tabsShown = 25;

		public history_page()
		{
			InitializeComponent();

            db_Refresh_HistoryTabs();

			ListViewHistory.ItemsSource = GLOBALS.HistoryTabs;

            Trace.WriteLine("init history");

		}

		public void resetAmtShown()
        {
			tabsShown = 25;
        }

		public void db_Refresh_HistoryTabs()
        {
			GLOBALS.HistoryTabs.Clear();

            int count = tabsShown;

            using (SqlConnection con = clsDB.Get_DB_Connection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_HistoryItems", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {

                            while (reader.Read() && count >= 0) 
                            {
                                GLOBALS.HistoryTabs.Add(new _HistoryTabs() { ParentTab = reader.GetString(1), Detail = reader.GetString(2) });
                                count++;
                            }
                        }
                    }
                }
            }
        }

        //TODO HISTORY PAGE connection to DB and connection to other actions from other tabs



	
	}
}

