using db_course_work_autoservice.ClientTools;
using db_course_work_autoservice.DB_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_course_work_autoservice.MainMenus
{
  public partial class ClientMainMenu : Form
  {
    private User user;
    private SignInForm parentSignInForm;
    private Form currentChildForm = null;

    public ClientMainMenu(SignInForm parentForm, User user)
    {
      this.user = user;
      this.parentSignInForm = parentForm;
      InitializeComponent();
      
      parentSignInForm.Hide();
    }

    private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
      parentSignInForm.Close();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      parentSignInForm.Show();
      if (currentChildForm != null)
      {
        currentChildForm.Close();
      }
      this.Dispose();
    }

    private void lkToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form newForm = new PersanalDataViewer(this, user);
      newForm.Show();
    }

    private void carsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form newForm = new MyCars(this, user);
      if (currentChildForm != null)
      {
        currentChildForm.Close();
      }
      currentChildForm = newForm;
      newForm.MdiParent = this;
      newForm.WindowState = FormWindowState.Maximized;
      newForm.BringToFront();
      newForm.Show();
    }

    private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form newForm = new ServicesForClient(this, user);
      if (currentChildForm != null)
      {
        currentChildForm.Close();
      }
      currentChildForm = newForm;
      newForm.MdiParent = this;
      newForm.WindowState = FormWindowState.Maximized;
      newForm.BringToFront();
      newForm.Show();
    }

    private void ClientMainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (currentChildForm != null)
      {
        currentChildForm.Close();
      }
      parentSignInForm.Close();
    }

    private void workToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form newForm = new WorksClientsForm(this, user);
      if (currentChildForm != null)
      {
        currentChildForm.Close();
      }
      currentChildForm = newForm;
      newForm.MdiParent = this;
      newForm.WindowState = FormWindowState.Maximized;
      newForm.BringToFront();
      newForm.Show();
    }
  }
}
