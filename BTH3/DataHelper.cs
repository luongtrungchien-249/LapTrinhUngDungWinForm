using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3
{
    internal class DataHelper
    {
        private string cn = "";
        private SqlConnection sqlConnection = new SqlConnection();

        public SqlConnection Connection
        {
            get { return sqlConnection; }
        }

        protected SqlConnection SqlConnection
        {
            get { return sqlConnection; }
            set { sqlConnection = value; }
        }

        public DataHelper() { }

        public DataHelper(string severName, string dataName)
        {
            cn = $@"Data Source={severName};Initial Catalog={dataName};Integrated Security=True;";
            sqlConnection.ConnectionString = cn;
        }

        public DataHelper(string severName, string dataName, string userName, string passWord)
        {
            cn = $@"Data Source={severName};Initial Catalog={dataName};User ID={userName};Password={passWord};";
            sqlConnection.ConnectionString = cn;
        }

        public void MoKetNoi()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void DongKetNoi()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public static void DocTep(string fileName, out string role, out string severName,
            out string dataName, out string userName, out string passWord)
        {
            role = severName = dataName = userName = passWord = "";

            if (!File.Exists(fileName))
                return;

            try
            {
                using (StreamReader dr = new StreamReader(fileName))
                {
                    if (!dr.EndOfStream) role = dr.ReadLine();
                    if (!dr.EndOfStream) severName = dr.ReadLine();
                    if (!dr.EndOfStream) dataName = dr.ReadLine();
                    if (!dr.EndOfStream) userName = dr.ReadLine();
                    if (!dr.EndOfStream) passWord = dr.ReadLine();
                }
            }
            catch { }
        }

        public static void GhiTep(string fileName, string role, string severName,
            string dataName, string userName, string passWord)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.WriteLine(role);
                    sw.WriteLine(severName);
                    sw.WriteLine(dataName);
                    sw.WriteLine(userName);
                    sw.WriteLine(passWord);
                }
            }
            catch { }
        }

    }


}

