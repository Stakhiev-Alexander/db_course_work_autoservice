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

namespace db_course_work_autoservice.MainMenus
{
   public partial class RegistrationForm : Form
  {
    Form parentSignInForm;
    int userType;
    int salary;
    int qualification;

    private static SqlConnection sqlConnection = new SqlConnection(
           "Server=(local);" +
           "User ID=sa;" +
           "Password=sa;" +
           "DataBase=autoservice;" +
           "MultipleActiveResultSets=True");

    public RegistrationForm(Form parentForm, int userType, int salary, int qualification)
    {
      this.salary = salary;
      this.qualification = qualification;
      this.parentSignInForm = parentForm;
      this.userType = userType;
      InitializeComponent();
      parentSignInForm.Hide();

      DataTable table = new DataTable();
      if (sqlConnection.State == ConnectionState.Closed)
      {
        sqlConnection.Open();
      }

      string sqlQuery = "select * from sex";
      using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
      {
        table.Load(command.ExecuteReader());
        SqlDataReader dr = command.ExecuteReader();
        if (dr.Read() == false)
        {
          sqlConnection.Close();
          throw new Exception("Ошбика вывода");
        }

        sex_cb.DataSource = table;
        sex_cb.DisplayMember = "sex_name";
      }
      sqlConnection.Close();
    }

    private void register_btn_Click(object sender, EventArgs e)
    {
      string login = login_tb.Text;
      string password = pass_tb.Text;
      string password_check = pass_check_tb.Text;
      string email = email_tb.Text;
      string fio = fio_tb.Text;
      string age_text = age_tb.Text;
      string sex_text = sex_cb.Text;
      Gender sex;
      int age;

      try
      {
        age = Convert.ToInt32(age_text);
        if (login.Length == 0 || password.Length == 0 || password_check.Length == 0 || email.Length == 0 || fio.Length == 0 || age_text.Length == 0 || sex_text.Length == 0)
        {
          MessageBox.Show("Какое-то из полей не было заполнено", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
          if (!password.Equals(password_check))
          {
            MessageBox.Show("Пароли не совпадют", "Пароли не совпадают", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          else
          {
            sex = (Gender)Enum.Parse(typeof(Gender), Convert.ToString(sex_text));
            User.addUserToDB(login, password, fio, sex, age, email, userType);
            if (userType == 2)
            {
              int id = User.getLastInsertedUsersID();
              User.addMasterToDB(id, salary, qualification);
            }
            this.Dispose();
            parentSignInForm.Show();
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Неправильный ввод", "Ошибка в вводе", MessageBoxButtons.OK, MessageBoxIcon.Error);
        age_tb.Text = "";
      } 
    }

    private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      parentSignInForm.Close();
    }
  }
}
