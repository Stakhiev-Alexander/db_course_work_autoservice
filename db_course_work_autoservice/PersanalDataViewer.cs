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

namespace db_course_work_autoservice
{
  public partial class PersanalDataViewer : Form
  {
    private User user;
    private Form parentForm;
    private User userBeforeDataChange;

    protected static SqlConnection sqlConnection = new SqlConnection(
            "Server=(local);" +
            "User ID=sa;" +
            "Password=sa;" +
            "DataBase=autoservice;" +
            "MultipleActiveResultSets=True");


    public PersanalDataViewer(Form parentForm, User user)
    {
      this.parentForm = parentForm;
      this.user = user;
      this.userBeforeDataChange = new User(user.login, user.password);

      InitializeComponent();

      fio_tb.Text = user.fio.Trim();
      sex_tb.Text = user.sex.ToString().Trim();
      age_tb.Text = user.age.ToString().Trim();
      email_tb.Text = user.internal_mail.Trim();
      login_tb.Text = user.login.Trim();
      password_tb.Text = user.password.Trim();

      parentForm.Hide();
    }

    private void PersanalDataViewer_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.Dispose();
      parentForm.Show();
    }

    private void personalInfoOk_btn_Click(object sender, EventArgs e)
    {
      try
      {
        if (login_tb.Text.Trim().Length == 0 || password_tb.Text.Trim().Length == 0)
        {
          MessageBox.Show("Логин и пароль не могут быть пустыми", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }
        user.fio = fio_tb.Text.Trim();
        Gender sex_gender_type;
        Enum.TryParse(sex_tb.Text.Trim(), out sex_gender_type);
        user.sex = sex_gender_type;
        user.age = int.Parse(age_tb.Text.Trim());
        user.internal_mail = email_tb.Text.Trim();
        user.login = login_tb.Text.Trim();
        user.password = password_tb.Text.Trim();
        user.updateUserInfo();
        MessageBox.Show("Данные успешно изменены", "Изменение личных данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        user.fio = userBeforeDataChange.fio;
        user.sex = userBeforeDataChange.sex;
        user.age = userBeforeDataChange.age;
        user.internal_mail = userBeforeDataChange.internal_mail;
        user.login = userBeforeDataChange.login;
        user.password = userBeforeDataChange.password;
        MessageBox.Show("Неправильно ввод одного или более полей", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
