using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_course_work_autoservice.DB_Connection
{
  class Storage
  {
    User user;
    protected static SqlConnection sqlConnection = new SqlConnection(
          "Server=(local);" +
          "User ID=sa;" +
          "Password=sa;" +
          "DataBase=autoservice;" +
          "MultipleActiveResultSets=True");

    public static void addDetailsToStorage(int id_detail, int count)
    {
      DataTable table = new DataTable();
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      string sqlQuery = "select id_storage_item, id_detail, count from storage where id_detail='" + id_detail + "'";
      
      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();
        if (dr.Read() == false)
        {
          SqlCommand cmd1 = new SqlCommand("AddDetailToStorage", sqlConnection);
          cmd1.CommandType = CommandType.StoredProcedure;

          cmd1.Parameters.Add(new SqlParameter("@id_detail", id_detail));
          cmd1.Parameters.Add(new SqlParameter("@count", count));

          cmd1.ExecuteNonQuery();

          sqlConnection.Close();
          return;
        }

        int count_new = Convert.ToInt32(dr[2]) + count;

        SqlCommand cmd = new SqlCommand("RemoveDetailFromStorage", sqlConnection);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@id_detail", id_detail));

        cmd.ExecuteNonQuery();

        cmd = new SqlCommand("AddDetailToStorage", sqlConnection);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@id_detail", id_detail));
        cmd.Parameters.Add(new SqlParameter("@count", count_new));

        cmd.ExecuteNonQuery();


        sqlConnection.Close();
      }      
    }

    public static void removeDetailsToStorage(int id_detail, int count)
    {
      DataTable table = new DataTable();
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      string sqlQuery = "select id_storage_item, id_detail, count from storage where id_detail='" + id_detail + "'";

      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();
        if (dr.Read() == false)
        {
          MessageBox.Show("Неправильный ввод данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
          sqlConnection.Close();
          return;
        }

        int count_new = Convert.ToInt32(dr[2]) - count;

        if (count_new > 0)
        {
          SqlCommand cmd = new SqlCommand("RemoveDetailFromStorage", sqlConnection);
          cmd.CommandType = CommandType.StoredProcedure;

          cmd.Parameters.Add(new SqlParameter("@id_detail", id_detail));

          cmd.ExecuteNonQuery();

          cmd = new SqlCommand("AddDetailToStorage", sqlConnection);
          cmd.CommandType = CommandType.StoredProcedure;

          cmd.Parameters.Add(new SqlParameter("@id_detail", id_detail));
          cmd.Parameters.Add(new SqlParameter("@count", count_new));

          cmd.ExecuteNonQuery();
       
        }
        else
        {
          SqlCommand cmd = new SqlCommand("RemoveDetailFromStorage", sqlConnection);
          cmd.CommandType = CommandType.StoredProcedure;

          cmd.Parameters.Add(new SqlParameter("@id_detail", id_detail));

          cmd.ExecuteNonQuery();
        }
        sqlConnection.Close();
      }
    }

  }
}
