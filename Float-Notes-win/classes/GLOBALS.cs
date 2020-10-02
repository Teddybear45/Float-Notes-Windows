using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Float_Notes_win.classes
{
    public static class GLOBALS
    {
        //history
        internal static ObservableCollection<_HistoryTabs> HistoryTabs = new ObservableCollection<_HistoryTabs>();
        internal static String currentTab = "HomePage";

        //tasks
        internal static ObservableCollection<_TaskItem> Tasks = new ObservableCollection<_TaskItem>();

        //filter for serialze and deserialize operations
        [Serializable]
        public class CustomFilter
        {
            public int FilterID { get; set; }
            public string UserID { get; set; }
            public string Description { get; set; }

            public List<String> Type { get; set; }
            public List<String> Category { get; set; }
            public List<String> Region { get; set; }
            public List<String> Branch { get; set; }


            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                var t = obj as CustomFilter;
                if (t == null)
                    return false;
                if (FilterID == t.FilterID)
                    return true;
                return false;
            }

            public override int GetHashCode()
            {
                int hash = 13;
                hash += (hash * 31) + FilterID.GetHashCode();

                return hash;
            }
        }

        //serializer
        public static String ObjectToXMLGeneric<T>(T filter)
        {
            string xml = null; 
            using(StringWriter sw = new StringWriter())
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(sw, filter);
                try
                {
                    xml = sw.ToString();
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
            return xml;
        }

        //deserializer
        public static T XMLToObject<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));

            using(var textReader = new StringReader(xml))
            {
                using (var xmlReader = XmlReader.Create(textReader))
                {
                    return (T)serializer.Deserialize(xmlReader);
                }
            }
        }

        //public void CreateFilter(CustomFilter filter)
        //{
        //    var FilterXML = GLOBALS.ObjectToXMLGeneric<CustomFilter>(filter);
        //
        //    DBUtil
        //}
    }

    
}
