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
            string queryString = $"SELECT [id] ,[Name] ,[Email] FROM [RIO1].[dbo].[Users]";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                UserModel u = new UserModel();
                u.Name = (string)reader["Name"];
                u.id = (int)reader["id"];
                u.Email = (string)reader["Email"];
                list.Add(u);
            }
            CloseConnection();
            return list;
        }

        public void InsertUser(UserModel model)
        {
            tryConnect();
            string queryString = $"INSERT INTO [RIO1].[dbo].[Users] (Name, Email) VALUES ('{model.Name}', '{model.Email}');";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void DeleteUser(int id)
        {
            tryConnect();
            string queryString = $"DELETE FROM [RIO1].[dbo].[Users] WHERE id='{id}';";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        private List<int> GetUserOrder(List<int> id)
        {
            tryConnect();
            //List<UserOrderModel> list = new List<UserOrderModel>();
            List<int> list = new List<int>();
            string l = "";
            for (int i = 0; i < id.Count; i++)
            {
                l += "'" + id[i].ToString() + "'";
                if (i + 1 != id.Count)
                    l += ",";

            }
            string queryString = $"SELECT [userId] ,[ModelId] FROM [RIO1].[dbo].[UserOrder] WHERE userId IN (" +l+")";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                //UserOrderModel uo = new UserOrderModel();
                //uo.userId = (string)reader["userId"];
                //uo.ModelId = (string)reader["ModelId"];
                list.Add((int)reader["ModelId"]);
            }
            CloseConnection();
            return list;
        }

        public List<OrderModel> GetOrdersList(List<int> id)
        {
            List<int> newid = GetUserOrder(id);
            tryConnect();
            List<OrderModel> list = new List<OrderModel>();
            string l = "";
            for(int i=0;i<newid.Count;i++)
            {
                l += "'" + newid[i].ToString() + "'";
                if (i + 1 != newid.Count)
                    l += ",";
                
            }
            string queryString = $"SELECT [id] ,[OrderItemId] ,[amount] ,[Price] FROM [RIO1].[dbo].[Orders] WHERE id IN ("+l+")";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                OrderModel o = new OrderModel();
                o.id = (string)reader["id"];
                o.OrderItemId = (string)reader["OrderItemId"];
                o.amount = (int)reader["amount"];
                o.Price = (int)reader["price"];
                list.Add(o);
            }
            CloseConnection();
            return list;
        }
        public List<OrderModel> GetOrdersList()
        {
            tryConnect();
            List<OrderModel> list = new List<OrderModel>();
            string queryString = $"SELECT [id] ,[OrderItemId] ,[amount] ,[Price] FROM [RIO1].[dbo].[Orders]";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                OrderModel o = new OrderModel();
                o.id = (string)reader["id"];
                o.OrderItemId = (string)reader["OrderItemId"];
                o.amount = (int)reader["amount"];
                o.Price = (int)reader["price"];
                list.Add(o);
            }
            CloseConnection();
            return list;
        }

        private List<int> GetOrderItem(List<int> id)
        {
            tryConnect();
            //List<UserOrderModel> list = new List<UserOrderModel>();
            List<int> list = new List<int>();
            string l = "";
            for (int i = 0; i < id.Count; i++)
            {
                l += "'" + id[i].ToString() + "'";
                if (i + 1 != id.Count)
                    l += ",";

            }
            string queryString = $"SELECT [id] ,[itemId] FROM [RIO1].[dbo].[OrderItem] WHERE id IN (" + l + ")";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                //UserOrderModel uo = new UserOrderModel();
                //uo.userId = (string)reader["userId"];
                //uo.ModelId = (string)reader["ModelId"];
                list.Add((int)reader["itemId"]);
            }
            CloseConnection();
            return list;
        }

        public List<ItemModel> GetItemsList(List<int> id)
        {
            List<int> newid = GetOrderItem(id);
            tryConnect();
            List<ItemModel> list = new List<ItemModel>();
            string l = "";
            for (int i = 0; i < newid.Count; i++)
            {
                l += "'" + newid[i].ToString() + "'";
                if (i + 1 != newid.Count)
                    l += ",";

            }
            string queryString = $"SELECT [id] ,[Name] FROM [RIO1].[dbo].[Items] WHERE id IN (" + l + ")";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ItemModel o = new ItemModel();
                o.id = (string)reader["id"];
                o.Name = (string)reader["Name"];
                list.Add(o);
            }
            CloseConnection();
            return list;
        }
        public List<ItemModel> GetItemsList()
        {
            tryConnect();
            List<ItemModel> list = new List<ItemModel>();
            string queryString = $"SELECT [id] ,[Name] FROM [RIO1].[dbo].[Items]";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ItemModel o = new ItemModel();
                o.id = (string)reader["id"];
                o.Name = (string)reader["Name"];
                list.Add(o);
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
