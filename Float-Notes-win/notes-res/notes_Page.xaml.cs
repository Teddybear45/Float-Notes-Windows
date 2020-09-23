using FloatLibrary;
using System;
using System.Collections.Generic;
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

    public partial class notes_page : Page
    {
        public List<SingleNoteStack> AllNotes = new List<SingleNoteStack>();

        public notes_page()
        {
            InitializeComponent();

            LoadNotesList();
            

        }

        private void LoadNotesList()
        {
            AllNotes = SqliteDataAccess.LoadNotes();
            
            WireUpNotesList();
        }

        private void WireUpNotesList()
        {
            //listNotesBox.DataContext = AllNotes;
            //listNotesBox.DisplayMemberPath = "Title";

            listNotesBox.ItemsSource = null;
            listNotesBox.ItemsSource = AllNotes;

            //listNotesBox.DisplayMemberPath = "NContent";
            

            
        }

        //if need refresh, use LoadNotesList()

        private void addNoteBtnClick(object sender, EventArgs e)
        {
            SingleNoteStack snp = new SingleNoteStack
            {
                Title = "test_INIT",
                ModifiedDate = DateTime.Now.Ticks,

                NContent = noteNContext.Text
            };

            SqliteDataAccess.SaveNote(snp);

            LoadNotesList();

            noteNContext.Text = "";
        }

        private void refreshNotesBtnClick(object sender, RoutedEventArgs e)
        {
            LoadNotesList();
        }

     
    }
    
}
