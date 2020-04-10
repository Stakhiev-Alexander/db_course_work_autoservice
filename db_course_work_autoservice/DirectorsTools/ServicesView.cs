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

namespace db_course_work_autoservice.DirectorsTools
{
  public partial class ServicesView : Form
  {
    private User user;
    private Form parentForm { get; }
    protected static SqlConnection sqlConnection = new SqlConnection(
        "Server=(local);" +
        "User ID=sa;" +
        "Password=sa;" +
        "DataBase=autoservice;" +
        "MultipleActiveResultSets=True");

    public ServicesView(Form parentForm, User user)
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

      string sqlQuery = "select id, name, price, qualification from services";
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

    private void delete_btn_Click(object sender, EventArgs e)
    {
      if (id_service_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        try
        {
          int serviceID = int.Parse(id_service_tb.Text);
          Works.removeService(serviceID);
          loadTable();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Неправильный ввод данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (name_tb.Text.Length == 0 || price_tb.Text.Length == 0 || qualification_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        try
        {
          int price = int.Parse(price_tb.Text);
          int qualification = int.Parse(qualification_tb.Text);
          string name = name_tb.Text;
          Works.createNewService(name, price, qualification);
          loadTable();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Неправильный ввод данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void id_master_tb_TextChanged(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void salary_tb_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void qualification_tb_TextChanged(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
  }
}
