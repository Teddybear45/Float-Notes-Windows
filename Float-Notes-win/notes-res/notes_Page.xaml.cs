﻿using Float_Notes_win._classes;
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

        int CurrentGeneralNoteID = -1;

        public notes_page()
        {
            InitializeComponent();


            db_Refresh_GeneralNotes();


            ListViewGeneralNotes.ItemsSource = GeneralNotes;

        }

        //takes values from DB and refreshes table
        private void db_Refresh_GeneralNotes()
        {
            GeneralNotes.Clear();

            using (SqlConnection con = clsDB.Get_DB_Connection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_GeneralNotes", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
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

        //returns ID of created
        private int db_Created_GeneralNote(_GeneralNote note)
        {

            clsDB.Execute_SQL($"INSERT INTO tbl_GeneralNotes (GeneralNoteContent)" + " VALUES ('" + note + "')");

            int insertedID = clsDB.ReadDataID("SELECT MAX(IDGeneralNotes) FROM tbl_GeneralNotes");

            Trace.WriteLine(insertedID + " insertedID");


            return insertedID;

        }

        private void GeneralNoteTextbox_GotFocus(object sender, RoutedEventArgs e)
        {
            GeneralNoteTextbox.SetValue(Grid.ColumnProperty, 0);
            GeneralNoteTextbox.SetValue(Grid.ColumnSpanProperty, 3);
            this.Resources["DynamicCreateNoteHeight"] = new GridLength(400);


        }

        private void GeneralNoteTextbox_LostFocus(object sender, RoutedEventArgs e)

        {
            if (GeneralNoteTextbox.Text != "")
            {
                GLOBALS.HistoryTabs.Add(new _HistoryTabs() { ParentTab = GLOBALS.currentTab, Detail = "IDGeneralNotes=" + CurrentGeneralNoteID });
            }

            CurrentGeneralNoteID = -1;
            GeneralNoteTextbox.Text = "";

            GeneralNoteTextbox.SetValue(Grid.ColumnProperty, 1);
            GeneralNoteTextbox.SetValue(Grid.ColumnSpanProperty, 2);
            this.Resources["DynamicCreateNoteHeight"] = new GridLength(120);

            db_Refresh_GeneralNotes();



        }

        private void GeneralNoteTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

            String checkText = GeneralNoteTextbox.Text;

            //if (checkText == "'" || checkText == "\"")
            //{
            //    checkText += "'";
            //}
            //
            //if (checkText != "")

            //TODO checktext for sql

            if (checkText != "")

            {
                if (CurrentGeneralNoteID == -1)
                {
                    //takes textbox text and creates new _GeneralNote from it
                    CurrentGeneralNoteID = db_Created_GeneralNote(new _GeneralNote() { content = checkText });

                }
                else
                {
                    clsDB.Execute_SQL($"UPDATE tbl_GeneralNotes SET GeneralNoteContent = " + "'" + checkText + "'" + " WHERE IDGeneralNotes = " + "'" + CurrentGeneralNoteID + "'");


                }
            }

            else
            {
                if (CurrentGeneralNoteID != -1)
                {
                    clsDB.Execute_SQL($"DELETE FROM tbl_GeneralNotes WHERE IDGeneralNotes = " + "'" + CurrentGeneralNoteID + "'");
                    CurrentGeneralNoteID = -1;

                }
            }


        }
    }

}
