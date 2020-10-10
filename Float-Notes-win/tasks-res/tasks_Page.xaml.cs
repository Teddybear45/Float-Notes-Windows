using Float_Notes_win._classes;
using Float_Notes_win.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            db_Refresh_TaskTags();
            InitializeComponent();
            ListViewTasksTags.ItemsSource = GLOBALS.Tags;
        }


        //takes values from DB and refreshes table
        private void db_Refresh_TaskTags()
        {
            GLOBALS.Tags.Clear();

            using (SqlConnection con = clsDB.Get_DB_Connection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Tags", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                GLOBALS.Tags.Add(new _TagItem() { Definition = reader.GetString(1) });

                            }
                        }
                    }
                }
            }
        }

        //private void createTaskBtn(object sender, RoutedEventArgs e)
        //{
        //    _TaskItem task = new _TaskItem();
        //    task.TaskContent = CreateTaskTextBox.Text;
        //    task.TaskPopTime = DateTime.Now.AddMinutes(2);

        //    GLOBALS.Tasks.Add(task);

            
        //    clsDB.Execute_SQL($"INSERT INTO tbl_TaskItems (TaskContent, TaskPopTime)" + " VALUES ('" + task.TaskContent + "', + '" + task.TaskPopTime + "')");
            

        //}

        private void createNewTagBtn(object sender, RoutedEventArgs e)
        {
            string newTag = "First Period Humanities";
            clsDB.Execute_SQL($"INSERT INTO tbl_Tags (Definition)" + " VALUES ('" + newTag + "')");
            GLOBALS.Tags.Add(new _TagItem() { Definition = newTag });
        }

        private void ConfirmNewTask_Click(object sender, RoutedEventArgs e)
        {
            _TaskItem task = new _TaskItem();
            task.TaskContent = CreateTaskTextBox.Text;
            task.TaskPopTime = DateTime.Now.AddMinutes(2);

            GLOBALS.Tasks.Add(task);


            clsDB.Execute_SQL($"INSERT INTO tbl_TaskItems (TaskContent, TaskPopTime)" + " VALUES ('" + task.TaskContent + "', + '" + task.TaskPopTime + "')");
        }
    }
}
