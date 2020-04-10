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
  public partial class WorksClientsForm : Form
  {
    private User user;
    private Form parentForm;
    protected static SqlConnection sqlConnection = new SqlConnection(
        "Server=(local);" +
        "User ID=sa;" +
        "Password=sa;" +
        "DataBase=autoservice;" +
        "MultipleActiveResultSets=True");

    public WorksClientsForm(Form parentForm, User user)
    {
      this.parentForm = parentForm;
      this.user = user;
      InitializeComponent();

      loadTable();
    }

    private void loadTable()
    {
      DataTable table = new DataTable();
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      string sqlQuery = @"select works.id, works.date_begin, works.date_end, works.car_id, cars.color, cars.mark
                          from works
                          join cars on (works.car_id = cars.car_id)
                          join clients on (cars.idUser = clients.id)
                          join users on (clients.userId = users.id)
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

    private void button1_Click(object sender, EventArgs e)
    {
      Form newForm = new AddWorkForm(this, user);

      parentForm.Hide();

      newForm.BringToFront();
      newForm.Show();

      loadTable();
    }
  }
}
