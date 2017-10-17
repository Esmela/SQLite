using SQLite.Droid;
using System.IO;
using Xamarin.Forms;


[assembly: Dependency(typeof(SQLite_Droid))]

namespace SQLite.Droid
{
    public class SQLite_Droid : ISQLite

    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}