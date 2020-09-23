using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace FloatLibrary
{
    public class SqliteDataAccess
    {

        public static List<SingleNoteStack> LoadNotes()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SingleNoteStack>("SELECT * FROM GeneralNotes", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveNote(SingleNoteStack note)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //cnn.Execute("INSERT INTO GeneralNotes (Title, ModifiedT, ContentN) VALUES (@Title, @ModifiedT, @ContentN)", note);
                cnn.Execute("INSERT INTO GeneralNotes (Title, ModifiedT, ContentN) VALUES ('test_title', 'time_example', 'some notes')", note);
            }
        }
    

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
