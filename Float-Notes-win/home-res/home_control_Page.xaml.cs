using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Float_Notes_win.sub_content
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            DispatcherTimer LiveTime = new DispatcherTimer();

            //set time before 1 second delay so filler text to shown text is streamlined
            LiveTimeHourMinute.Content = DateTime.Now.ToString("h:mm");
            LiveTimeMonthDay.Content = DateTime.Now.ToString("dddd, MMMM d");

            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeHourMinute.Content = DateTime.Now.ToString("h:mm");
            LiveTimeMonthDay.Content = DateTime.Now.ToString("dddd, MMMM d");
        }



    }




}
