using db_course_work_autoservice.DB_Connection;
using db_course_work_autoservice.MainMenus;
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

namespace db_course_work_autoservice.DirectorsTools
{
  public partial class MasterView : Form
  {
    private User user;
    private Form parentForm { get; }
    protected static SqlConnection sqlConnection = new SqlConnection(
        "Server=(local);" +
        "User ID=sa;" +
        "Password=sa;" +
        "DataBase=autoservice;" +
        "MultipleActiveResultSets=True");

    public MasterView(Form parentForm, User user)
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

      string sqlQuery = "select masters.id, users.fio, qualification, salary from masters, users where masters.userId = users.id";
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

    private void button1_Click(object sender, EventArgs e)
    {
      if (salary_tb.Text.Length == 0 || qualification_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      } else
      {
        try
        {
          int salary = int.Parse(salary_tb.Text);
          int qualification = int.Parse(qualification_tb.Text);
          Form registerForm = new RegistrationForm(this.parentForm, 2, salary, qualification);
          registerForm.Show();

          loadTable();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Неправильный ввод данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void delete_btn_Click(object sender, EventArgs e)
    {
      if (id_master_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        try
        {
          int masterID = int.Parse(id_master_tb.Text);
          User.removeMaster(masterID);
          loadTable();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Неправильный ввод данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
