using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_course_work_autoservice.DB_Connection
{
  class Shops
  {
    User user;
    protected static SqlConnection sqlConnection = new SqlConnection(
          "Server=(local);" +
          "User ID=sa;" +
          "Password=sa;" +
          "DataBase=autoservice;" +
          "MultipleActiveResultSets=True");

    public static void addNewShop(string name, string address, string email)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      SqlCommand cmd = new SqlCommand("AddShop", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@name", name));
      cmd.Parameters.Add(new SqlParameter("@address", address));
      cmd.Parameters.Add(new SqlParameter("@email", email));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
    }

    public static void removeShop(int id)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      SqlCommand cmd = new SqlCommand("RemoveShop", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@id", id));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
    }
  }
}
