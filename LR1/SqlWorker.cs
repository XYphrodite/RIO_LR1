using LR1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<UserModel> getListOfUsers()
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

        public void InsertOrder(OrderModel model)
        {
            tryConnect();
            string queryString = $"INSERT INTO [RIO1].[dbo].[Orders] (userId, amount, cost) VALUES ('{model.userId}', '{model.amount}', '{model.cost}');";
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
        public void DeleteOrder(int id)
        {
            tryConnect();
            string queryString = $"DELETE FROM [RIO1].[dbo].[Orders] WHERE id='{id}';";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public List<OrderModel> GetOrdersList(List<int> id)
        {
            tryConnect();
            List<OrderModel> list = new List<OrderModel>();
            string l = "";
            for (int i = 0; i < id.Count; i++)
            {
                l += "'" + id[i].ToString() + "'";
                if (i + 1 != id.Count)
                    l += ",";

            }
            string queryString = $"SELECT [id] ,[userId] ,[amount] ,[cost] FROM [RIO1].[dbo].[Orders] WHERE id IN (" + l + ")";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                OrderModel o = new OrderModel();
                o.id = (int)reader["id"];
                o.userId = (int)reader["userId"];
                o.amount = (int)reader["amount"];
                o.cost = (int)reader["cost"];
                list.Add(o);
            }
            CloseConnection();
            return list;
        }
        public List<OrderModel> GetOrdersList()
        {
            tryConnect();
            List<OrderModel> list = new List<OrderModel>();
            string queryString = $"SELECT [id] ,[userId] ,[amount] ,[cost] FROM [RIO1].[dbo].[Orders]";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                OrderModel o = new OrderModel();
                o.id = (int)reader["id"];
                o.userId = (int)reader["userId"];
                o.amount = (int)reader["amount"];
                o.cost = (int)reader["cost"];
                list.Add(o);
            }
            CloseConnection();
            return list;
        }



        public List<ItemModel> GetItemsList(List<int> id)
        {
            tryConnect();
            List<ItemModel> list = new List<ItemModel>();
            string l = "";
            for (int i = 0; i < id.Count; i++)
            {
                l += "'" + id[i].ToString() + "'";
                if (i + 1 != id.Count)
                    l += ",";

            }
            string queryString = $"SELECT [id] ,[Name], [orderId] FROM [RIO1].[dbo].[Items] WHERE orderId IN (" + l + ")";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ItemModel o = new ItemModel();
                o.id = (int)reader["id"];
                o.Name = (string)reader["Name"];
                o.orderId = (int)reader["orderId"];
                list.Add(o);
            }
            CloseConnection();
            return list;
        }
        public List<ItemModel> GetItemsList()
        {
            tryConnect();
            List<ItemModel> list = new List<ItemModel>();
            string queryString = $"SELECT [id] ,[Name], [orderId] FROM [RIO1].[dbo].[Items]";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ItemModel o = new ItemModel();
                o.id = (int)reader["id"];
                o.Name = (string)reader["Name"];
                o.orderId = (int)reader["orderId"];
                list.Add(o);
            }
            CloseConnection();
            return list;
        }

        private void CloseConnection()
        {
            sqlConnection.Close();
        }

        internal void InsertItem(ItemModel model)
        {
            tryConnect();
            string queryString = $"INSERT INTO [RIO1].[dbo].[Items] (orderId, Name) VALUES ('{model.orderId}', '{model.Name}');";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        internal void DeleteItem(int id)
        {
            tryConnect();
            string queryString = $"DELETE FROM [RIO1].[dbo].[Items] WHERE id='{id}';";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        internal List<DeliveryModel> GetDeliveryList(List<int> id)
        {
            tryConnect();
            List<DeliveryModel> list = new List<DeliveryModel>();
            string l = "";
            for (int i = 0; i < id.Count; i++)
            {
                l += "'" + id[i].ToString() + "'";
                if (i + 1 != id.Count)
                    l += ",";

            }
            string queryString = $"SELECT [name], [orderId], [cost] FROM [RIO1].[dbo].[Deliveries] WHERE orderId IN (" + l + ")";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DeliveryModel d = new DeliveryModel();
                d.orderId = (int)reader["orderId"];
                d.companyName = (string)reader["name"];
                d.cost = (int)reader["cost"];
                list.Add(d);
            }
            CloseConnection();
            return list;
        }

        internal List<DeliveryModel> GetDeliveryList()
        {
            tryConnect();
            List<DeliveryModel> list = new List<DeliveryModel>();
            string queryString = $"SELECT [name], [orderId], [cost] FROM [RIO1].[dbo].[Deliveries]";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                DeliveryModel d = new DeliveryModel();
                d.orderId = (int)reader["orderId"];
                d.companyName = (string)reader["name"];
                d.cost = (int)reader["cost"];
                list.Add(d);
            }
            CloseConnection();
            return list;
        }

        internal void InsertDelivery(DeliveryModel model)
        {
            tryConnect();
            string queryString = $"INSERT INTO [RIO1].[dbo].[Deliveries] (orderId, Name, cost) VALUES ('{model.orderId}', '{model.companyName}', '{model.cost}');";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        internal void DeleteDelivery(int id)
        {
            tryConnect();
            string queryString = $"DELETE FROM [RIO1].[dbo].[Deliveries] WHERE orderId='{id}';";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        internal List<monthlyCostModel> GetCostsList(List<int> id)
        {
            tryConnect();
            List<monthlyCostModel> list = new List<monthlyCostModel>();
            string l = "";
            for (int i = 0; i < id.Count; i++)
            {
                l += "'" + id[i].ToString() + "'";
                if (i + 1 != id.Count)
                    l += ",";

            }
            string queryString = $"SELECT [itemId], [monthName], [cost] FROM [RIO1].[dbo].[MonthlyCost] WHERE itemId IN (" + l + ")";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                monthlyCostModel m = new monthlyCostModel();
                m.itemId = (int)reader["itemId"];
                m.monthName = (string)reader["monthName"];
                m.cost = (int)reader["cost"];
                list.Add(m);
            }
            CloseConnection();
            return list;
        }

        internal List<monthlyCostModel> GetCostsList()
        {
            tryConnect();
            List<monthlyCostModel> list = new List<monthlyCostModel>();
            string queryString = $"SELECT [itemId], [monthName], [cost] FROM [RIO1].[dbo].[MonthlyCost]";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                monthlyCostModel m = new monthlyCostModel();
                m.itemId = (int)reader["itemId"];
                m.monthName = (string)reader["monthName"];
                m.cost = (int)reader["cost"];
                list.Add(m);
            }
            CloseConnection();
            return list;
        }

        internal void InsertCost(monthlyCostModel model)
        {
            tryConnect();
            string queryString = $"INSERT INTO [RIO1].[dbo].[MonthlyCost] (itemId, monthName, cost) VALUES ('{model.itemId}', '{model.monthName}', '{model.cost}');";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }

        internal void DeleteCost(int id)
        {
            tryConnect();
            string queryString = $"DELETE FROM [RIO1].[dbo].[MonthlyCost] WHERE itemId='{id}';";
            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
