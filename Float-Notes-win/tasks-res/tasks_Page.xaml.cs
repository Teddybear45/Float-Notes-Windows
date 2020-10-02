using Float_Notes_win._classes;
using Float_Notes_win.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
using System.Xml.Linq;

namespace Float_Notes_win.tasks_res
{
    /// <summary>
    /// Interaction logic for tasks_Page.xaml
    /// </summary>
    public partial class tasks_Page : Page
    {
                
        public tasks_Page()
        {
            InitializeComponent();
        }
        
        private void createTaskBtn(object sender, RoutedEventArgs e)
        {
            _TaskItem task = new _TaskItem();
            task.TaskContent = "test test new task task content content 1234";
            task.TaskPopTime = DateTime.Now.AddMinutes(2);

            GLOBALS.Tasks.Add(task);

            
            clsDB.Execute_SQL($"INSERT INTO tbl_TaskItems (TaskContent, TaskPopTime)" + " VALUES ('" + task.TaskContent + "', + '" + task.TaskPopTime + "')");
            

        }


    }
}
