using CAIT.SQLHelper;
using ShoesOnline.Const;
using ShoesOnline.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace ShoesOnline.Repositories
{
    public class TestRes
    {
        public static List<Test> LayKhongThamSo()
        {
            SqlConnection connection = new SqlConnection(ConstValue.ConnectString);
            String sql = "SELECT * FROM TestTable";

            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            List<Test> testList = new List<Test>();

            while (dataReader.Read())
            {
                Test t = new Test();
                t.ID = dataReader.GetValue("ID").ToString();
                t.Name = dataReader.GetValue("Name").ToString();
                
                testList.Add(t);
            }

            dataReader.Close();
            command.Dispose();
            connection.Close();
        
            return testList;
        }
    }
}
