using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace db_course_work_autoservice.DB_Connection
{
  public enum User_type
  {
    DIRECTOR,
    MASTER,
    CLIENT
  }

  public enum Gender
  {
    MALE,
    FEMALE,
    TRANSGENDER
  }

  public class User
  {
    public int user_id { get; set; }
    public string login { get; set; }
    public string password { get; set; }
    public User_type user_type { get; set; }
    public string fio { get; set; }
    public Gender sex { get; set; }
    public int age { get; set; }
    public string internal_mail { get; set; }

    protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=autoservice;" +
            "MultipleActiveResultSets=True");

    public User(string login, string password)
    {
      DataTable table = new DataTable();
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }
      string sqlQuery = "select * from users where users.login='" + login + "' and users.password='" + password + "'";
      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();
        if (dr.Read() == false)
        {
          sqlConnection.Close();
          throw new Exception("Неправильный логин или пароль");
        }
        this.user_id = Convert.ToInt32(dr[0]);
        this.login = Convert.ToString(dr[1]);
        this.password = Convert.ToString(dr[2]);
        this.user_type = (User_type) Enum.ToObject(typeof(User_type), Convert.ToInt32(dr[3]) - 1);
        this.fio = Convert.ToString(dr[4]);
        this.sex = (Gender) Enum.Parse(typeof(Gender), Convert.ToString(dr[5]));
        this.age = Convert.ToInt32(dr[6]);
        this.internal_mail = Convert.ToString(dr[7]);

        sqlConnection.Close();
      }
    }

    public static void addMasterToDB(int id, int salary, int qualification)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      SqlCommand cmd = new SqlCommand("AddMaster", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@userId", id));
      cmd.Parameters.Add(new SqlParameter("@salary", salary));
      cmd.Parameters.Add(new SqlParameter("@qualification", qualification));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
    }

    public static void addUserToDB(string login, string password, string fio, Gender sex, int age, string email, int user_type)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }
      string sqlQuery = @"INSERT INTO users(login,password, user_type, fio, sex_name, age, email)
                                    VALUES(
                                           @login, 
                                           @password, 
                                           @user_type,
                                           @fio,
                                           @sex_name,
                                           @age,
                                           @email
                                           )";
      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        command.Parameters.Add("@login", SqlDbType.VarChar, 50).Value = login;
        command.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
        command.Parameters.Add("@user_type", SqlDbType.Int).Value = user_type;
        command.Parameters.Add("@sex_name", SqlDbType.VarChar, 25).Value = sex.ToString();
        command.Parameters.Add("@fio", SqlDbType.VarChar, 100).Value = fio;
        command.Parameters.Add("@age", SqlDbType.Int).Value = age;
        command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
        command.CommandType = CommandType.Text;
        command.ExecuteNonQuery();
      }

      if (user_type == 3) { 
        sqlQuery = @"INSERT INTO clients(userID)
                                    VALUES(
                                           @userID
                                           )";
        using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
        {
          command.Parameters.Add("@userID", SqlDbType.Int).Value = User.getLastInsertedUsersID();
          command.CommandType = CommandType.Text;
          command.ExecuteNonQuery();
        }
    }
      sqlConnection.Close();
    }

    public void updateUserInfo()
    {
      bool opened = true;
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
        opened = false;
      }
      SqlCommand cmd = new SqlCommand("UpdateUser", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@id", user_id));
      cmd.Parameters.Add(new SqlParameter("@login", login));
      cmd.Parameters.Add(new SqlParameter("@password", password));
      cmd.Parameters.Add(new SqlParameter("@fio", fio));
      cmd.Parameters.Add(new SqlParameter("@sex", sex.ToString()));
      cmd.Parameters.Add(new SqlParameter("@age", age));
      cmd.Parameters.Add(new SqlParameter("@email", internal_mail));

      cmd.ExecuteNonQuery();
      if (!opened)
        sqlConnection.Close();
    }

    public static int getLastInsertedUsersID()
    {
      int max_id = -1;
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }
      string sqlQuery = "SELECT MAX( users.id ) AS id FROM users";
      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        SqlDataReader dr = command.ExecuteReader();
        if (dr.Read() == false)
        {
          sqlConnection.Close();
          throw new Exception("Неправильный логин или пароль");
        }
        max_id = Convert.ToInt32(dr[0]);

        sqlConnection.Close();
        return max_id;
      }
    }

    public static void removeMaster(int masierID)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      SqlCommand cmd = new SqlCommand("RemoveMaster", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@id", masierID));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
    }
  }
}
