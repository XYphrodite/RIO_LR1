using LR1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    internal class SqlWorker
    {
        string connetionString = string.Empty;
        SqlConnection sqlConnection;
        public SqlWorker()
        {

        }
        private bool tryConnect()
        {
            connetionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RIO1;Integrated Security=True";
            sqlConnection = new SqlConnection(connetionString);
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<UserModel> getListOfMembers()
        {
            tryConnect();
            List<UserModel> list = new List<UserModel>();
            string queryString = $"SELECT TOP (1000) [id] ,[Name] ,[Email] FROM [RIO1].[dbo].[Users]";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                UserModel u = new UserModel();
                u.Name = (string)reader["Name"];
                u.id = (string)reader["id"];
                u.Email = (string)reader["Email"];
                list.Add(u);
            }
            CloseConnection();
            return list;
        }
        private void CloseConnection()
        {
            sqlConnection.Close();
        }
    }
}
