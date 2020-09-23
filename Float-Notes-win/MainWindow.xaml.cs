using Float_Notes_win.sub_content;
using Float_Notes_win.User_Controls;
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

        public MainWindow()
        {
            InitializeComponent();
            //subscribing to events e.g. nameOfComponent.Action += new ActionHandler(.....)

            Main.Content = new HomePage();


        }


        private void MinimizeControlBoardClick(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicControlBoardWidth"] = new GridLength(95);
            
            //hides max and shows min
            minControlBoardBtn.Visibility = Visibility.Hidden;
            maxControlBoardBtn.Visibility = Visibility.Visible;

            //hides text of control board
            homeControlBoardText.Visibility = Visibility.Hidden;
            historyControlBoardText.Visibility = Visibility.Hidden;
            calendarControlBoardText.Visibility = Visibility.Hidden;
            classesControlBoardText.Visibility = Visibility.Hidden;
            notesControlBoardText.Visibility = Visibility.Hidden;
            tasksControlBoardText.Visibility = Visibility.Hidden;
            plusNoteControlBoardText.Visibility = Visibility.Hidden;
            plusTaskControlBoardText.Visibility = Visibility.Hidden;
            plusReminderControlBoardText.Visibility = Visibility.Hidden;
            //plusMeetingControlBoardText.Visibility = Visibility.Hidden;

            //changes to button and grid and image and img alignment inside each segment of control board

            homeControlBoardBtnGrid.Width = (Double)55;
            homeControlPanelBtn.Width = (Double)60;
            this.Resources["DynamicPortionControlBoardBtn"] = new GridLength(0);
            this.Resources["DynamicControlBoardBtnImgAlignment"] = HorizontalAlignment.Center;



        }

        private void MaxmizeControlBoardClick(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicControlBoardWidth"] = new GridLength(195);
            
            //hides min and shows max
            minControlBoardBtn.Visibility = Visibility.Visible;
            maxControlBoardBtn.Visibility = Visibility.Hidden;
            
            //shows text of control board
            homeControlBoardText.Visibility = Visibility.Visible;
            historyControlBoardText.Visibility = Visibility.Visible;
            calendarControlBoardText.Visibility = Visibility.Visible;
            classesControlBoardText.Visibility = Visibility.Visible;
            notesControlBoardText.Visibility = Visibility.Visible;
            tasksControlBoardText.Visibility = Visibility.Visible;
            plusNoteControlBoardText.Visibility = Visibility.Visible;
            plusTaskControlBoardText.Visibility = Visibility.Visible;
            plusReminderControlBoardText.Visibility = Visibility.Visible;
            //plusMeetingControlBoardText.Visibility = Visibility.Visible;

        }


        private void HistoryBtnClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new history_page();

        }

        private void NotesBtnClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new notes_page();
        }
        
        private void HomeBtnClick(object sender, RoutedEventArgs e)
        {
            Main.Content = new HomePage();

        }
    }
}
