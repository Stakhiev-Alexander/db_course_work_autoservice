using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using db_course_work_autoservice.DB_Connection;
using db_course_work_autoservice.MainMenus;

namespace db_course_work_autoservice
{
  public partial class SignInForm : Form
  {
    private Form mainForm;
    public SignInForm()
    {
      InitializeComponent();
    }

    private void signUp_lbl_Click(object sender, EventArgs e)
    {
      RegistrationForm registerForm = new RegistrationForm(this, 3 , -1, -1);
      registerForm.Show();
    }

    private void signIn_btn_Click(object sender, EventArgs e)
    {
      String login = login_tb.Text;
      String password = pass_tb.Text;

      if (login.Length == 0 || password.Length == 0)
      {
        MessageBox.Show("Поле логина или пароля не заполненно", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        try
        {
          User user = new User(login, password);
          switch (user.user_type)
          {
            case User_type.DIRECTOR:
              this.mainForm = new DirectorMainMenu(this, user);
              break;
            case User_type.MASTER:
              this.mainForm = new MasterMainMenu(this, user);
              break;
            case User_type.CLIENT:
              this.mainForm = new ClientMainMenu(this, user);
              break;
            default:
              throw new Exception();
          }
          login_tb.Text = "";
          pass_tb.Text = "";
          mainForm.Show();
        } 
        catch (Exception exception)
        {
          MessageBox.Show("Неправильный логин или пароль", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

  }
}
