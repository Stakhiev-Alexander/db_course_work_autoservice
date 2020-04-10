namespace db_course_work_autoservice
{
  partial class DirectorMainMenu
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
      this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.мастераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.закупкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.личныйКабинетToolStripMenuItem,
            this.мастераToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.закупкиToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.выйтиToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(883, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // личныйКабинетToolStripMenuItem
      // 
      this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
      this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
      this.личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
      this.личныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.личныйКабинетToolStripMenuItem_Click);
      // 
      // мастераToolStripMenuItem
      // 
      this.мастераToolStripMenuItem.Name = "мастераToolStripMenuItem";
      this.мастераToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
      this.мастераToolStripMenuItem.Text = "Мастера";
      this.мастераToolStripMenuItem.Click += new System.EventHandler(this.мастераToolStripMenuItem_Click);
      // 
      // услугиToolStripMenuItem
      // 
      this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
      this.услугиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
      this.услугиToolStripMenuItem.Text = "Услуги";
      this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
      // 
      // закупкиToolStripMenuItem
      // 
      this.закупкиToolStripMenuItem.Name = "закупкиToolStripMenuItem";
      this.закупкиToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
      this.закупкиToolStripMenuItem.Text = "Закупки";
      this.закупкиToolStripMenuItem.Click += new System.EventHandler(this.закупкиToolStripMenuItem_Click);
      // 
      // поставщикиToolStripMenuItem
      // 
      this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
      this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
      this.поставщикиToolStripMenuItem.Text = "Поставщики";
      this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
      // 
      // выйтиToolStripMenuItem
      // 
      this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
      this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
      this.выйтиToolStripMenuItem.Text = "Выйти";
      this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
      // 
      // DirectorMainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(883, 522);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "DirectorMainMenu";
      this.Text = "MainMenu";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem мастераToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem закупкиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
  }
}