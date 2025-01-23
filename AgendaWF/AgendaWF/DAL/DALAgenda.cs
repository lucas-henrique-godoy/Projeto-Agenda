using AgendaWF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace AgendaWF.DAL
{
    public class DALAgenda : Contato
    {
        public static string path = Directory.GetCurrentDirectory() + "\\banco.sqlite";
        private static SQLiteConnection sqliteConnection;

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=" + path);
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void CriarBancoSQLite()
        {
            try
            {
                if (File.Exists(path) == false)
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void CriarTabelaSQLite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Contatos(id int, nome Varchar(50), email Varchar(80), telefone Varchar(20))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable GetContatos()
        {
            return new DataTable();
        }

        public static DataTable GetContato(int id)
        {
            return new DataTable();
        }

        public static void Add(Contato contato)
        {
            
        }

        public static void Update(Contato contato) 
        {
        
        }

        public static void Delete(int id)
        {

        }

    }
}
