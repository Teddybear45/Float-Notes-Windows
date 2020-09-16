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
            

        }

        private void LoadNotesList()
        {
            WireUpNotesList();
        }

        private void WireUpNotesList()
        {
            //listNotesBox.DataSource = null;
            //listNotesBox.DataContext = AllNotes;
            //listNotesBox.DisplayMemberPath = "Title";

            listNotesBox.ItemsSource = null;
            listNotesBox.ItemsSource = AllNotes;
            

            
        }

        //if need refresh, use LoadNotesList()

        private void addNoteBtnClick(object sender, EventArgs e)
        {
            SingleNoteStack snp = new SingleNoteStack();

            snp.Title = "test_INIT";
            snp.ModifiedDate = DateTime.Now.Ticks;

            snp.NContent = noteNContext.Text;

            AllNotes.Add(snp);
            WireUpNotesList();

            noteNContext.Text = "";
        }
        



    }
    
}
