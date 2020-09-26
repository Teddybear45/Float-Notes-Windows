using Float_Notes_win._classes;
using Float_Notes_win.classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
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

    public partial class notes_page : Page
    {

        ObservableCollection<_GeneralNote> GeneralNotes = new ObservableCollection<_GeneralNote>();

        public notes_page()
        {
            InitializeComponent();

            //GeneralNotes.Add(new _GeneralNote() { content = "1123" });

            db_Refresh_GeneralNotes();

            
            
            
            listNotesBox.ItemsSource = GeneralNotes;
            
        }

        private void db_Update_Add_GeneralNote(_GeneralNote note)
        {
            Trace.WriteLine("db_Update_Add_GeneralNote");

            clsDB.Execute_SQL($"INSERT INTO tbl_GeneralNotes (GeneralNoteContent)" + " VALUES ('" + note + "')");

            db_Refresh_GeneralNotes();

        }

        private void db_Refresh_GeneralNotes()
        {
            GeneralNotes.Clear();

            using(SqlConnection con = clsDB.Get_DB_Connection())
            {
                using(SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_GeneralNotes", con))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                GeneralNotes.Add(new _GeneralNote() { content = reader.GetString(1) });
                            }
                        }
                    }
                }
            }
        
        
        }

        private void btn_click_AddNote(object sender, RoutedEventArgs e)
        {
            db_Update_Add_GeneralNote(new _GeneralNote() {content=GeneralNoteTextbox.Text });
            GeneralNoteTextbox.Text = "";
        }

        private void db_GetData_updateList()
        {
            
        }

        private void btn_refresh(object sender, RoutedEventArgs e)
        {
            
            Trace.WriteLine(GeneralNotes);
        }
    }

}
