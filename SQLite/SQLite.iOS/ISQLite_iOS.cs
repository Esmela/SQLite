using System;
using Xamarin.Forms;
using System.IO;
using SQLite.iOS;

[assembly: Dependency(typeof(ISQLite_iOS))]

namespace SQLite.iOS
{
    public  class ISQLite_iOS : ISQLite
    {

        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, filename);
        }
    }
}