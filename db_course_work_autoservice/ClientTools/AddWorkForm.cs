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
  public partial class AddWorkForm : Form
  {
    private User user;
    private Form parentForm { get; }
    protected static SqlConnection sqlConnection = new SqlConnection(
       "Server=(local);" +
       "User ID=sa;" +
       "Password=sa;" +
       "DataBase=autoservice;" +
       "MultipleActiveResultSets=True");

    public AddWorkForm(Form parentForm, User user)
    {
      this.parentForm = parentForm;
      this.user = user;
      InitializeComponent();

      parentForm.Hide();

      fillCarComboBox();
      fillServicesComboBox();
    }

    private void fillCarComboBox()
    {
      DataTable table = new DataTable();
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      string sqlQuery = @"select cars.car_id
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

        car_id_cb.DataSource = table;
        car_id_cb.DisplayMember = "car_id";
      }
      sqlConnection.Close();
    }

    private void fillServicesComboBox()
    {
      DataTable table = new DataTable();
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      string sqlQuery = "select name from services";
      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();
        if (dr.Read() == false)
        {
          sqlConnection.Close();
          throw new Exception("Ошбика вывода");
        }

        services_cb.DataSource = table;
        services_cb.DisplayMember = "name";
      }
      sqlConnection.Close();
    }

    private void AddWorkForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      parentForm.WindowState = FormWindowState.Maximized;
      parentForm.Show();
      parentForm.ParentForm.Show();
      this.Dispose();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      listBox1.Items.Add(services_cb.Text);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      listBox1.Update();
      List<string> serviceList = new List<string>(0);
      for (int i = 0; i < listBox1.Items.Count; i++)
      {
        string service = listBox1.Items[i].ToString();
        serviceList.Add(service);
      }
      Works.createNewWork(car_id_cb.Text, serviceList);
    }
  }
}
