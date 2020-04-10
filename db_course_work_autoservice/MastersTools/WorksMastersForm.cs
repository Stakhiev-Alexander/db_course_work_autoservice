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

namespace db_course_work_autoservice.MastersTools
{
  public partial class WorksMastersForm : Form
  {
    private User user;
    private Form parentForm;
    protected static SqlConnection sqlConnection = new SqlConnection(
        "Server=(local);" +
        "User ID=sa;" +
        "Password=sa;" +
        "DataBase=autoservice;" +
        "MultipleActiveResultSets=True");

    public WorksMastersForm(Form parentForm, User user)
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

      string sqlQuery = @"select works.id, works.date_begin, works.date_end, works.car_id, cars.mark, cars.color
                          from works
                          join cars on (works.car_id = cars.car_id)
                          join masters on (works.master_id = masters.id)
                          join users on (masters.userId = users.id)
                          where date_end IS NULL and date_begin IS NOT NULL and users.id = '" + user.user_id + "'";

      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();

        dataGridView1.DataSource = table;

        sqlConnection.Close();
      }
    }

    private void end_btn_Click(object sender, EventArgs e)
    {
      if (id_work_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        Works.finishWork(int.Parse(id_work_tb.Text));
        loadTable();
      }
    }
  }
}
