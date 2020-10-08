using Float_Notes_win.classes;
using Float_Notes_win.sub_content;
using Float_Notes_win.tasks_res;
using Float_Notes_win.user_controls;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Float_Notes_win
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //pages
        Page Key_HomePage = new HomePage();
        Page Key_HistoryPage = new history_page();
        Page Key_NotesPage = new notes_page();
        Page Key_TasksPage = new tasks_Page();

        List<CBBtn_UC> CBItems = new List<CBBtn_UC>();

        public MainWindow()
        {
            InitializeComponent();
            //subscribing to events e.g. nameOfComponent.Action += new ActionHandler(.....)

            //initializes content when loaded to be of main
            Main.Content = Key_HomePage;

            InitializeControlBoard();

        }

        private void InitializeControlBoard()
        {

            CBItems.Add(CBCtrlHome);
            CBItems.Add(CBCtrlHistory);
            CBItems.Add(CBCtrlCalendar);
            CBItems.Add(CBCtrlClassOverview);
            CBItems.Add(CBCtrlNotes);
            CBItems.Add(CBCtrlTasks);
            CBItems.Add(CBCtrlCreateNote);
            CBItems.Add(CBCtrlCreateTask);
            CBItems.Add(CBCtrlCreateReminder);
            CBItems.Add(CBCtrlCreateMeeting);

        }

        //minimizing control board and child elements
        private void MinimizeControlBoardClick(object sender, RoutedEventArgs e)
        {
            //sets control board width to smaller amt
            controlBoardCol.Width = new GridLength(95);

            //hides max and shows min
            minControlBoardBtn.Visibility = Visibility.Hidden;
            maxControlBoardBtn.Visibility = Visibility.Visible;

            //hides text of control board
            foreach (CBBtn_UC CB in CBItems)
            {
                CB.BtnTxtBlock.Visibility = Visibility.Hidden;

                //changes to button and grid and image and img alignment inside each segment of control board
                CB.BtnGridColLen = new GridLength(0);
                //CB.BtnImg.HorizontalAlignment = HorizontalAlignment.Center;

                CB.BtnGrid.Width = (Double)55;
                CB.Btn.Width = (double)50;

                CB.Status.Margin = new Thickness(0, 0, 0, 0);


            }
        }

        private void MaxmizeControlBoardClick(object sender, RoutedEventArgs e)
        {
            //sets control board width to greater amt
            controlBoardCol.Width = new GridLength(195);

            //hides max and shows min
            minControlBoardBtn.Visibility = Visibility.Visible;
            maxControlBoardBtn.Visibility = Visibility.Hidden;

            //hides text of control board
            foreach (CBBtn_UC CB in CBItems)
            {
                //CB.BtnTxt.Visibility = Visibility.Visible;

                ////changes to button and grid and image and img alignment inside each segment of control board
                //CB.BtnGridLen2.Width = new GridLength(4, GridUnitType.Star);
                //CB.BtnImg.HorizontalAlignment = HorizontalAlignment.Left;

                //CB.BtnGrid.Width = (Double)135;
                //CB.Btn.Width = (Double)150;

                //CB.Status.Margin = new Thickness(-35, 0, 0, 0);
            }

        }


        private void HistoryBtnClick(object sender, RoutedEventArgs e)
        {
            Main.Content = Key_HistoryPage;
            GLOBALS.currentTab = "HistoryPage";

        }

        private void HomeBtnClick(object sender, RoutedEventArgs e)
        {
            Main.Content = Key_HomePage;
            GLOBALS.currentTab = "HomePage";

        }

        private void TasksBtnClick(object sender, RoutedEventArgs e)
        {
            Main.Content = Key_TasksPage;
            GLOBALS.currentTab = "TasksPage";
        }

        private void CBCtrlNotes_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = Key_NotesPage;
            GLOBALS.currentTab = "NotesPage";
        }

        private void CBCtrlTasks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBCtrlHistory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBCtrlHome_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBCtrlCalendar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBCtrlClassOverview_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBCtrlCreateNote_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBCtrlCreateTask_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBCtrlCreateReminder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CBCtrlCreateMeeting_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
