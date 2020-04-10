namespace db_course_work_autoservice.MainMenus
{
  partial class MasterMainMenu
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
            this.выйтиToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 28);
      this.menuStrip1.TabIndex = 1;
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
      this.мастераToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
      this.мастераToolStripMenuItem.Text = "Мои заказы";
      this.мастераToolStripMenuItem.Click += new System.EventHandler(this.мастераToolStripMenuItem_Click);
      // 
      // услугиToolStripMenuItem
      // 
      this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
      this.услугиToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
      this.услугиToolStripMenuItem.Text = "Список заказов";
      this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
      // 
      // выйтиToolStripMenuItem
      // 
      this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
      this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
      this.выйтиToolStripMenuItem.Text = "Выйти";
      this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click_1);
      // 
      // MasterMainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.Name = "MasterMainMenu";
      this.Text = "MasterMainMenu";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem мастераToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
  }
}