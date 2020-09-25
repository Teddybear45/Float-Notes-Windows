﻿using Float_Notes_win._classes;
using System;
using System.Collections.Generic;
using System.Data;
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

    public partial class notes_page : Page
    {

        public notes_page()
        {
            InitializeComponent();


        }

        private void db_Update_Add_GeneralNote(string note)
        {

            //removes notes quotes and puts single quotes for sql read
            note = note.Replace("'", "''");

            string sSQL = "SELECT TOP 1 * FROM tbl_GeneralNotes";
            DataTable tbl = clsDB.Get_DataTable(sSQL);

            Trace.WriteLine("db_Update_Add_GeneralNote");

            clsDB.Execute_SQL($"INSERT INTO tbl_GeneralNotes (GeneralNoteContent)" + " VALUES ('" + note + "')");


        }

        private void btn_click_AddNote(object sender, RoutedEventArgs e)
        {
            db_Update_Add_GeneralNote("testest1212121121313");
        }
    }

}
