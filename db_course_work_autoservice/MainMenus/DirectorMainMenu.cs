using db_course_work_autoservice.DB_Connection;
using db_course_work_autoservice.DirectorsTools;
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
  public partial class DirectorMainMenu : Form
  {
    private User user;
    private SignInForm parentSignInForm;
    private Form currentChildForm = null;
    private static SqlConnection sqlConnection = new SqlConnection(
       "Server=(local);" +
       "User ID=sa;" +
       "Password=sa;" +
       "DataBase=autoservice;" +
       "MultipleActiveResultSets=True");

    public DirectorMainMenu(SignInForm parentForm, User user)
    {
      this.user = user;
      InitializeComponent();
      this.parentSignInForm = parentForm;
      parentSignInForm.Hide();
    }

    private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      parentSignInForm.Show();
      this.Dispose();
    }

    private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (currentChildForm != null)
      {
        currentChildForm.Close();
      }
      parentSignInForm.Close();
    }

    private void мастераToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form newForm = new MasterView(this, user);
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

    private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form newForm = new ServicesView(this, user);
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

    private void закупкиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form newForm = new StorageView(this, user);
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

    private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form newForm = new PersanalDataViewer(this, user);
      newForm.Show();
    }

    private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form newForm = new ShopsView(this, user);
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
