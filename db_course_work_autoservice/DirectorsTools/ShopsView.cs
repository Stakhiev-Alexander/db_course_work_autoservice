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
  public partial class ShopsView : Form
  {
    private User user;
    private Form parentForm { get; }
    protected static SqlConnection sqlConnection = new SqlConnection(
        "Server=(local);" +
        "User ID=sa;" +
        "Password=sa;" +
        "DataBase=autoservice;" +
        "MultipleActiveResultSets=True");

    public ShopsView(Form parentForm, User user)
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

      string sqlQuery = "select id_shop, name, address, email from shops";
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

    private void add_btn_Click(object sender, EventArgs e)
    {
      if (name_tb.Text.Length == 0 || address_tb.Text.Length == 0 || email_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        try
        {
          string name = name_tb.Text;
          string address = address_tb.Text;
          string email = email_tb.Text;
          Shops.addNewShop(name, address, email);
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
      if (id_shop_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        try
        {
          int id = int.Parse(id_shop_tb.Text);
          Shops.removeShop(id);
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
