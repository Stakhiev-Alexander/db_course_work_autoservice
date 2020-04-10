using db_course_work_autoservice.DB_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_course_work_autoservice.ClientTools
{
  public partial class MyCars : Form
  {
    private User user;
    private Form parentForm;
    protected static SqlConnection sqlConnection = new SqlConnection(
        "Server=(local);" +
        "User ID=sa;" +
        "Password=sa;" +
        "DataBase=autoservice;" +
        "MultipleActiveResultSets=True");

    public MyCars(Form parentForm, User user)
    {
      this.parentForm = parentForm;
      this.user = user;
      InitializeComponent();
      //parentForm.Hide();
      loadTable();
    }

    private void loadTable()
    {
      DataTable table = new DataTable();
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      string sqlQuery = @"select cars.car_id, cars.color, cars.mark 
                          from cars 
                          join clients on cars.idUser = clients.id 
                          join users on users.id = clients.userId
                          where users.id = '" + user.user_id + "'";

      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();
        if (dr.Read() == false)
        {
          sqlConnection.Close();
          throw new Exception("Ошбика вывода");
        }

        dataGridView1.DataSource = table;

        sqlConnection.Close();
      }
    }

    private void insertCar(string number, string mark, string color, int userID)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }
      SqlCommand cmd = new SqlCommand("AddCar", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@car_id", number));
      cmd.Parameters.Add(new SqlParameter("@mark", mark));
      cmd.Parameters.Add(new SqlParameter("@color", color));
      cmd.Parameters.Add(new SqlParameter("@idUser", userID));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
    }


    private void button1_Click(object sender, EventArgs e)
    {
      if (color_tb.Text.Length == 0 || mark_tb.Text.Length == 0 || number_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      { 
        insertCar(number_tb.Text, mark_tb.Text, color_tb.Text, user.user_id);
        loadTable();
      }
    }

    private void back_btn_Click(object sender, EventArgs e)
    {

    }

    private void MyCars_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void delete_btn_Click(object sender, EventArgs e)
    {
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }
      SqlCommand cmd = new SqlCommand("RemoveCar", sqlConnection);
      cmd.CommandType = CommandType.StoredProcedure;

      cmd.Parameters.Add(new SqlParameter("@car_id", car_to_delete_tb.Text));

      cmd.ExecuteNonQuery();
      sqlConnection.Close();
      loadTable();
    }
  }
}
