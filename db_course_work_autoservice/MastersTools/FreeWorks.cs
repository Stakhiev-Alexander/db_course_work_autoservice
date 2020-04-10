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
  public partial class FreeWorks : Form
  {
    private User user;
    private Form parentForm;
    protected static SqlConnection sqlConnection = new SqlConnection(
        "Server=(local);" +
        "User ID=sa;" +
        "Password=sa;" +
        "DataBase=autoservice;" +
        "MultipleActiveResultSets=True");

    public FreeWorks(Form parentForm, User user)
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

      string sqlQuery = @"SELECT res1.id, res1.date_begin, res1.date_end, res1.car_id, res1.mark, res1.color, res2.max_needed_qualification FROM
                          (
	                          SELECT works.id, works.date_begin, works.date_end, works.car_id, cars.mark, cars.color
	                          FROM works
	                          JOIN cars ON (works.car_id = cars.car_id)
	                          WHERE date_end IS NULL and date_begin IS NULL and master_id IS NULL
                          ) AS res1
                          JOIN
                          (
	                          SELECT works.id, MAX(qualification) AS max_needed_qualification
	                          FROM services
	                          JOIN work_services ON services.id = work_services.id_service
	                          JOIN works ON work_services.id_work = works.id
	                          GROUP BY works.id
                          ) AS res2
                          ON (res2.id = res1.id)
                          ";

      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();

        dataGridView1.DataSource = table;

        sqlConnection.Close();
      }
    }

    private void take_btn_Click(object sender, EventArgs e)
    {
      if (id_work_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        Works.assignMasterToWork(user.user_id, int.Parse(id_work_tb.Text));
        loadTable();
      }
    }
  }
}
