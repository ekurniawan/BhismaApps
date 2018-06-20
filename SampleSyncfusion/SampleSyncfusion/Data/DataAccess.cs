using Plugin.NetStandardStorage.Abstractions.Interfaces;
using Plugin.NetStandardStorage.Implementations;
using SampleSyncfusion.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SampleSyncfusion.Data
{
    public class DataAccess
    {
        SQLiteConnection database;

        public SQLiteConnection GetConnection()
        {
            SQLiteConnection sqliteConnection;
            var sqliteFileName = "MyAppDb.db3";
            IFolder folder = new FileSystem().LocalStorage;
            string path = Path.Combine(folder.FullPath, sqliteFileName);
            sqliteConnection = new SQLiteConnection(path);
            return sqliteConnection;
        }

        public DataAccess()
        {
            database = GetConnection();
            database.CreateTable<Biodata>();
            database.CreateTable<LogData>();
        }

        #region Table Biodata

        /*public int TambahBiodata(Biodata biodata)
        {
            return database.Insert(biodata);
        }

        public IEnumerable<Biodata> GetAllBiodata()
        {
            return database.Query<Biodata>("select * from Biodata order by Nama");
        }

        public int InsertBiodata(Biodata biodata)
        {
            return database.Insert(biodata);
        }

        public int EditBiodata(Biodata biodata)
        {
            return database.Update(biodata);
        }

        public int DeleteBiodata(Biodata biodata)
        {
            return database.Delete(biodata);
        }*/

        #endregion

        #region Table LogData

        public IEnumerable<LogData> GetAllLogData()
        {
            return database.Query<LogData>("select * from LogData order by LogID");
        }
        
        public int InsertLogData(LogData logdata)
        {
            return database.Insert(logdata);
        }

        public int EditLogData(LogData logdata)
        {
            return database.Update(logdata);
        }

        public int DeleteLogData(LogData logdata)
        {
            return database.Delete(logdata);
        }

        #endregion
    }
}
