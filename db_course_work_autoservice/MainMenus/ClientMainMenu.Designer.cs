namespace db_course_work_autoservice.MainMenus
{
  partial class ClientMainMenu
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.lkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.workToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lkToolStripMenuItem,
            this.workToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.carsToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // lkToolStripMenuItem
      // 
      this.lkToolStripMenuItem.Name = "lkToolStripMenuItem";
      this.lkToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
      this.lkToolStripMenuItem.Text = "Личный кабинет";
      this.lkToolStripMenuItem.Click += new System.EventHandler(this.lkToolStripMenuItem_Click);
      // 
      // servicesToolStripMenuItem
      // 
      this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
      this.servicesToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
      this.servicesToolStripMenuItem.Text = "Услуги";
      this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
      // 
      // carsToolStripMenuItem
      // 
      this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
      this.carsToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
      this.carsToolStripMenuItem.Text = "Мои машины";
      this.carsToolStripMenuItem.Click += new System.EventHandler(this.carsToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
      this.exitToolStripMenuItem.Text = "Выйти";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // workToolStripMenuItem
      // 
      this.workToolStripMenuItem.Name = "workToolStripMenuItem";
      this.workToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
      this.workToolStripMenuItem.Text = "Мои заказы";
      this.workToolStripMenuItem.Click += new System.EventHandler(this.workToolStripMenuItem_Click);
      // 
      // ClientMainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.Name = "ClientMainMenu";
      this.Text = "ClientMainMenu";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientMainMenu_FormClosing);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem lkToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem workToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}