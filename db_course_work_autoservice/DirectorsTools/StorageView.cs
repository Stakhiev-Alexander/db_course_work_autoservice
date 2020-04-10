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
  public partial class StorageView : Form
  {
    private User user;
    private Form parentForm { get; }
    protected static SqlConnection sqlConnection = new SqlConnection(
        "Server=(local);" +
        "User ID=sa;" +
        "Password=sa;" +
        "DataBase=autoservice;" +
        "MultipleActiveResultSets=True");

    public StorageView(Form parentForm, User user)
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

      string sqlQuery = "select warehouse.id_detail, warehouse.name, warehouse.price, storage.count from warehouse, storage where storage.id_detail=warehouse.id_detail";
      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();
        if (dr.Read() == false)
        {
          sqlConnection.Close();
          // throw new Exception("Ошибка работы базы данных");
          MessageBox.Show("Ошибка работы базы данных", "Ошибка бд", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        dataGridView1.DataSource = table;

        dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

        dr.Close();
      }
      sqlConnection.Close();
    }

    private void add_btn_Click(object sender, EventArgs e)
    {
      if (id_detail_add_tb.Text.Length == 0 || number_to_add_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        try
        {
          int id_detail = int.Parse(id_detail_add_tb.Text);
          int number_to_add = int.Parse(number_to_add_tb.Text);
          Storage.addDetailsToStorage(id_detail, number_to_add);
          loadTable();
          dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Неправильный ввод данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void delete_btn_Click(object sender, EventArgs e)
    {
      if (id_detail_delete_tb.Text.Length == 0 || number_to_delete_tb.Text.Length == 0)
      {
        MessageBox.Show("Остались пустые поля", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        try
        {
          int id_detail = int.Parse(id_detail_delete_tb.Text);
          int number_to_remove = int.Parse(number_to_delete_tb.Text);
          Storage.removeDetailsToStorage(id_detail, number_to_remove);
          loadTable();
          dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Неправильный ввод данных", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
