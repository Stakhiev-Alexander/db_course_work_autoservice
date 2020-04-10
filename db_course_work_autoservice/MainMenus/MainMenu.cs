using db_course_work_autoservice.DB_Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_course_work_autoservice.MainMenus
{
  public class MainMenu : Form
  {
    private User user;
    private SignInForm parentSignInForm;

    private MainMenu()
    {

    }

    private void Init(SignInForm parentForm, User user)
    {
      this.user = user;
      this.parentSignInForm = parentForm;
      parentSignInForm.Hide();
    }
  }
}
