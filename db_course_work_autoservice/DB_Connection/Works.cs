using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_course_work_autoservice.DB_Connection
{
  class Works
  {
    User user;
    protected static SqlConnection sqlConnection = new SqlConnection(
          "Server=(local);" +
          "User ID=sa;" +
          "Password=sa;" +
          "DataBase=autoservice;" +
          "MultipleActiveResultSets=True");

    public Works()
    {

    }

    public static void assignMasterToWork(int user_id, int work_id)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      SqlCommand cmd = new SqlCommand("AssignMasterToWork", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@id", work_id));
      cmd.Parameters.Add(new SqlParameter("@user_id", user_id));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
    }

    public static void createNewWork(string car_id, List<string> serviceList)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }
      string sqlQuery = @"INSERT INTO works (car_id)  VALUES( @car_id )";

      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        command.Parameters.Add("@car_id", SqlDbType.VarChar, 10).Value = car_id;
        command.CommandType = CommandType.Text;
        command.ExecuteNonQuery();
      }
      
      foreach (string str in serviceList)
      {
        sqlQuery = @"INSERT INTO work_services (id_work, id_service)  VALUES( (select MAX(id) as id_work from works), 
                                                                              (select id from services where name = @name) )";

        using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
        {
          command.Parameters.Add("@name", SqlDbType.VarChar, 50).Value = str;
          command.CommandType = CommandType.Text;
          command.ExecuteNonQuery();
        }
      }

      sqlConnection.Close();
    }

    public static void removeService(int idService)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      SqlCommand cmd = new SqlCommand("RemoveService", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@id", idService));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
    }

    public static void createNewService(string name, int price, int qualification)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      SqlCommand cmd = new SqlCommand("AddService", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@name", name));
      cmd.Parameters.Add(new SqlParameter("@price", price));
      cmd.Parameters.Add(new SqlParameter("@qualification", qualification));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
    }

    public static void finishWork(int idWork)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      SqlCommand cmd = new SqlCommand("FinishWork", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@id", idWork));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
    }
  }
}
