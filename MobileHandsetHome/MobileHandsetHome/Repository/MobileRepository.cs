using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using MobileHandsetHome.Model;

namespace MobileHandsetHome.Repository
{
    class MobileRepository
    {
        public bool SaveMobiles(Mobile _mobile)
        {
           // List<Mobile> mobiles=new List<Mobile>();
            string connectionString = @"Server=PC-301-29\SQLEXPRESS; Database=MobileHandsetsInformation; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"insert into MobileHandset values('"+_mobile.ModelName+"','"+_mobile.Imei+"',"+_mobile.Price+")";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                return true;
            }
            sqlConnection.Close();
            return false;
        }

        public List<Mobile> SearchByPriceRange(Mobile _mobile)
        {
            List<Mobile>mobiles=new List<Mobile>();
            string connectionString = @"Server=PC-301-29\SQLEXPRESS; Database=MobileHandsetsInformation; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT Model_Name,IMEI,Price FROM MobileHandset
                                     WHERE Price BETWEEN "+_mobile.MinPrice+" AND "+_mobile.MaxPrice+"";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Mobile mobile=new Mobile();
                mobile.Price =Convert.ToInt32(sqlDataReader["Price"].ToString()) ;
                mobiles.Add(mobile);
            }
            sqlConnection.Close();
            return mobiles;

        }
        public List<Mobile> SearchByImei(Mobile _mobile)
        {
            List<Mobile> mobiles = new List<Mobile>();
            string connectionString = @"Server=PC-301-29\SQLEXPRESS; Database=MobileHandsetsInformation; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM MobileHandset where IMEI='"+_mobile.Imei+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
               Mobile mobile = new Mobile();
               // mobile.Price = Convert.ToInt32(sqlDataReader["Price"].ToString());
               mobile.ModelName = sqlDataReader["Model_Name"].ToString();
               mobile.Imei = sqlDataReader["IMEI"].ToString();
               mobile.Price = Convert.ToInt32(sqlDataReader["Price"].ToString());
               mobiles.Add(mobile);
            }
            sqlConnection.Close();
            return mobiles;

        }

    }
}
