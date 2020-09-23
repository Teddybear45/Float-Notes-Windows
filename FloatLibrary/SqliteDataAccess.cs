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
                var output = cnn.Query<SingleNoteStack>("select * from GeneralNotes", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveNote(SingleNoteStack note)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into GeneralNotes (Title, ModifiedT, ContentN) values (@Title, @ModifiedDate, @NContent)", note);
            }
        }
    

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
