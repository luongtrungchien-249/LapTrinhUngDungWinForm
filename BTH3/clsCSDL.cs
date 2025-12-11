using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BTH3
{
    internal class clsCSDL  : DataHelper
    {
        public clsCSDL() : base() { }

        public clsCSDL(string severname, string dataname) : base(severname, dataname) { }

        public clsCSDL(string severname, string dataname, string username, string password)
            : base(severname, dataname, username, password) { }

        public SqlDataReader ExecuteReader(string command)
        {
            SqlCommand cmd = new SqlCommand(command, SqlConnection);
            if (SqlConnection.State == ConnectionState.Closed)
                MoKetNoi();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader ExecuteReader(string command, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(command, SqlConnection);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            if (SqlConnection.State == ConnectionState.Closed)
                MoKetNoi();

            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public int ExecuteNonQuery(string command, SqlParameter[] parameters = null)
        {
            SqlCommand cmd = new SqlCommand(command, SqlConnection);
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            if (SqlConnection.State == ConnectionState.Closed)
                MoKetNoi();

            int result = cmd.ExecuteNonQuery();
            DongKetNoi();
            return result;
        }

        public int StoreNonQuery(string storeName, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(storeName, SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            if (SqlConnection.State == ConnectionState.Closed)
                MoKetNoi();

            int result = cmd.ExecuteNonQuery();
            DongKetNoi();
            return result;
        }

        public SqlDataReader StoreReader(string storeName, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(storeName, SqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            if (SqlConnection.State == ConnectionState.Closed)
                MoKetNoi();

            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }


    }
}
