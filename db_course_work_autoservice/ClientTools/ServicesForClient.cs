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
  public partial class ServicesForClient : Form
  {
    private User user;
    private Form parentForm;
    protected static SqlConnection sqlConnection = new SqlConnection(
        "Server=(local);" +
        "User ID=sa;" +
        "Password=sa;" +
        "DataBase=autoservice;" +
        "MultipleActiveResultSets=True");

    public ServicesForClient(Form parentForm, User user)
    {
      this.parentForm = parentForm;
      this.user = user;
      InitializeComponent();

      DataTable table = new DataTable();
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      string sqlQuery = "select name, price from services";
      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();
        if (dr.Read() == false)
        {
          sqlConnection.Close();
          //throw new Exception("Ошибка работы базы данных");
          MessageBox.Show("Ошибка работы базы данных", "Ошибка бд", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        dataGridView1.DataSource = table;

        dr.Close();
      }
      sqlConnection.Close();
    }
  }
}
