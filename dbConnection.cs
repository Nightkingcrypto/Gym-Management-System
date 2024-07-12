using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    internal class dbConnection
    {
        string path = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GymManager"), "gymData.db");
        string connectionString = @"URI=file:" + Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GymManager"), "gymData.db") + 
            ";datetimeformat=CurrentCulture";

        SQLiteConnection conn;

        public void checkDataBaseAvailability()
        {
            if (!System.IO.File.Exists(path))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GymManager"));
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "CREATE TABLE Members (MemberId INTEGER  not null PRIMARY KEY AUTOINCREMENT, FirstName varchar(50), LastName varchar(50), Gender varchar(10), DateOfBirth date, Email varchar(100), Phone varchar(15), JoinDate date, MembershipType varchar(20));";
                    SQLiteCommand cmd = new SQLiteCommand(sql, sqlite);
                    cmd.ExecuteNonQuery();

                    sql = "CREATE TABLE Trainers (TrainerId INTEGER  not null PRIMARY KEY AUTOINCREMENT, FirstName varchar(50), LastName varchar(50), Gender varchar(10), DateOfBirth date, Email varchar(100), Phone varchar(15), Specialization varchar(500));";
                    cmd = new SQLiteCommand(sql, sqlite);
                    cmd.ExecuteNonQuery();

                    sql = "CREATE TABLE Payments (PaymentId INTEGER  not null PRIMARY KEY AUTOINCREMENT, MemberId INTEGER NOT NULL, PaymentAmount DECIMAL(18,2) NOT NULL, PaymentDate date NOT NULL);";
                    cmd = new SQLiteCommand(sql, sqlite);
                    cmd.ExecuteNonQuery();

                    sql = "CREATE TABLE Equipments (EquipmentId INTEGER  not null PRIMARY KEY AUTOINCREMENT, Name varchar(50) NOT NULL, Price DECIMAL(18,2) NOT NULL, DateOfPurchase date NOT NULL, Quantity integer not null, Other varchar(500) not null);";
                    cmd = new SQLiteCommand(sql, sqlite);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SQLiteConnection initConnection()
        {
            conn = new SQLiteConnection(connectionString);
            return conn;
        }
    }
}
