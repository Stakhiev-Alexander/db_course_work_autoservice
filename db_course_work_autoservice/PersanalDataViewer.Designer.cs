namespace db_course_work_autoservice
{
  partial class PersanalDataViewer
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
      this.personalInfo_gb = new System.Windows.Forms.GroupBox();
      this.userInfo_table = new System.Windows.Forms.TableLayoutPanel();
      this.login_tb = new System.Windows.Forms.TextBox();
      this.password_tb = new System.Windows.Forms.TextBox();
      this.sex_tb = new System.Windows.Forms.TextBox();
      this.name_lbl = new System.Windows.Forms.Label();
      this.gender_lbl = new System.Windows.Forms.Label();
      this.birthday_lbl = new System.Windows.Forms.Label();
      this.fio_tb = new System.Windows.Forms.TextBox();
      this.birthday_flowPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.age_tb = new System.Windows.Forms.TextBox();
      this.email_lbl = new System.Windows.Forms.Label();
      this.email_tb = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.personalInfoOk_btn = new System.Windows.Forms.Button();
      this.personalInfo_gb.SuspendLayout();
      this.userInfo_table.SuspendLayout();
      this.birthday_flowPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // personalInfo_gb
      // 
      this.personalInfo_gb.Controls.Add(this.userInfo_table);
      this.personalInfo_gb.Dock = System.Windows.Forms.DockStyle.Fill;
      this.personalInfo_gb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.personalInfo_gb.Location = new System.Drawing.Point(0, 0);
      this.personalInfo_gb.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
      this.personalInfo_gb.MaximumSize = new System.Drawing.Size(530, 310);
      this.personalInfo_gb.MinimumSize = new System.Drawing.Size(530, 310);
      this.personalInfo_gb.Name = "personalInfo_gb";
      this.personalInfo_gb.Padding = new System.Windows.Forms.Padding(10, 3, 10, 5);
      this.personalInfo_gb.Size = new System.Drawing.Size(530, 310);
      this.personalInfo_gb.TabIndex = 3;
      this.personalInfo_gb.TabStop = false;
      this.personalInfo_gb.Text = "Личные данные:";
      // 
      // userInfo_table
      // 
      this.userInfo_table.ColumnCount = 2;
      this.userInfo_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.userInfo_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this.userInfo_table.Controls.Add(this.login_tb, 1, 4);
      this.userInfo_table.Controls.Add(this.password_tb, 0, 5);
      this.userInfo_table.Controls.Add(this.sex_tb, 1, 1);
      this.userInfo_table.Controls.Add(this.name_lbl, 0, 0);
      this.userInfo_table.Controls.Add(this.gender_lbl, 0, 1);
      this.userInfo_table.Controls.Add(this.birthday_lbl, 0, 2);
      this.userInfo_table.Controls.Add(this.fio_tb, 1, 0);
      this.userInfo_table.Controls.Add(this.birthday_flowPanel, 1, 2);
      this.userInfo_table.Controls.Add(this.email_lbl, 0, 3);
      this.userInfo_table.Controls.Add(this.email_tb, 1, 3);
      this.userInfo_table.Controls.Add(this.label1, 0, 4);
      this.userInfo_table.Controls.Add(this.label2, 0, 5);
      this.userInfo_table.Dock = System.Windows.Forms.DockStyle.Fill;
      this.userInfo_table.Location = new System.Drawing.Point(10, 25);
      this.userInfo_table.Name = "userInfo_table";
      this.userInfo_table.RowCount = 6;
      this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.userInfo_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.userInfo_table.Size = new System.Drawing.Size(510, 280);
      this.userInfo_table.TabIndex = 2;
      // 
      // login_tb
      // 
      this.login_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.login_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.login_tb.Location = new System.Drawing.Point(156, 169);
      this.login_tb.Name = "login_tb";
      this.login_tb.Size = new System.Drawing.Size(320, 22);
      this.login_tb.TabIndex = 106;
      // 
      // password_tb
      // 
      this.password_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.password_tb.Location = new System.Drawing.Point(156, 229);
      this.password_tb.Name = "password_tb";
      this.password_tb.Size = new System.Drawing.Size(320, 22);
      this.password_tb.TabIndex = 103;
      // 
      // sex_tb
      // 
      this.sex_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.sex_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.sex_tb.Location = new System.Drawing.Point(156, 49);
      this.sex_tb.Name = "sex_tb";
      this.sex_tb.Size = new System.Drawing.Size(320, 22);
      this.sex_tb.TabIndex = 105;
      // 
      // name_lbl
      // 
      this.name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.name_lbl.AutoSize = true;
      this.name_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.name_lbl.Location = new System.Drawing.Point(110, 11);
      this.name_lbl.Name = "name_lbl";
      this.name_lbl.Size = new System.Drawing.Size(40, 17);
      this.name_lbl.TabIndex = 0;
      this.name_lbl.Text = "ФИО:";
      // 
      // gender_lbl
      // 
      this.gender_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.gender_lbl.AutoSize = true;
      this.gender_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.gender_lbl.Location = new System.Drawing.Point(115, 51);
      this.gender_lbl.Name = "gender_lbl";
      this.gender_lbl.Size = new System.Drawing.Size(35, 17);
      this.gender_lbl.TabIndex = 1;
      this.gender_lbl.Text = "Пол:";
      // 
      // birthday_lbl
      // 
      this.birthday_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.birthday_lbl.AutoSize = true;
      this.birthday_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.birthday_lbl.Location = new System.Drawing.Point(92, 91);
      this.birthday_lbl.Name = "birthday_lbl";
      this.birthday_lbl.Size = new System.Drawing.Size(58, 17);
      this.birthday_lbl.TabIndex = 2;
      this.birthday_lbl.Text = "Возраст:";
      // 
      // fio_tb
      // 
      this.fio_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.fio_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.fio_tb.Location = new System.Drawing.Point(156, 9);
      this.fio_tb.Name = "fio_tb";
      this.fio_tb.Size = new System.Drawing.Size(320, 22);
      this.fio_tb.TabIndex = 0;
      // 
      // birthday_flowPanel
      // 
      this.birthday_flowPanel.Controls.Add(this.age_tb);
      this.birthday_flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.birthday_flowPanel.Location = new System.Drawing.Point(153, 80);
      this.birthday_flowPanel.Margin = new System.Windows.Forms.Padding(0);
      this.birthday_flowPanel.Name = "birthday_flowPanel";
      this.birthday_flowPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
      this.birthday_flowPanel.Size = new System.Drawing.Size(357, 40);
      this.birthday_flowPanel.TabIndex = 7;
      // 
      // age_tb
      // 
      this.age_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.age_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.age_tb.Location = new System.Drawing.Point(3, 6);
      this.age_tb.Name = "age_tb";
      this.age_tb.Size = new System.Drawing.Size(320, 22);
      this.age_tb.TabIndex = 104;
      // 
      // email_lbl
      // 
      this.email_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.email_lbl.AutoSize = true;
      this.email_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.email_lbl.Location = new System.Drawing.Point(103, 131);
      this.email_lbl.Name = "email_lbl";
      this.email_lbl.Size = new System.Drawing.Size(47, 17);
      this.email_lbl.TabIndex = 10;
      this.email_lbl.Text = "Почта:";
      // 
      // email_tb
      // 
      this.email_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.email_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.email_tb.Location = new System.Drawing.Point(156, 129);
      this.email_tb.Name = "email_tb";
      this.email_tb.Size = new System.Drawing.Size(320, 22);
      this.email_tb.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(103, 171);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 17);
      this.label1.TabIndex = 101;
      this.label1.Text = "Логин:";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(93, 231);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 17);
      this.label2.TabIndex = 102;
      this.label2.Text = "Пароль:";
      // 
      // personalInfoOk_btn
      // 
      this.personalInfoOk_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.personalInfoOk_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.personalInfoOk_btn.Location = new System.Drawing.Point(417, 313);
      this.personalInfoOk_btn.Margin = new System.Windows.Forms.Padding(0, 3, 33, 0);
      this.personalInfoOk_btn.Name = "personalInfoOk_btn";
      this.personalInfoOk_btn.Size = new System.Drawing.Size(113, 35);
      this.personalInfoOk_btn.TabIndex = 100;
      this.personalInfoOk_btn.Text = "Изменить";
      this.personalInfoOk_btn.UseVisualStyleBackColor = true;
      this.personalInfoOk_btn.Click += new System.EventHandler(this.personalInfoOk_btn_Click);
      // 
      // PersanalDataViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(548, 358);
      this.Controls.Add(this.personalInfo_gb);
      this.Controls.Add(this.personalInfoOk_btn);
      this.Name = "PersanalDataViewer";
      this.Text = "PersanalDataViewer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersanalDataViewer_FormClosing);
      this.personalInfo_gb.ResumeLayout(false);
      this.userInfo_table.ResumeLayout(false);
      this.userInfo_table.PerformLayout();
      this.birthday_flowPanel.ResumeLayout(false);
      this.birthday_flowPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.GroupBox personalInfo_gb;
    private System.Windows.Forms.TableLayoutPanel userInfo_table;
    private System.Windows.Forms.Label name_lbl;
    private System.Windows.Forms.Label gender_lbl;
    private System.Windows.Forms.Label birthday_lbl;
    private System.Windows.Forms.TextBox fio_tb;
    private System.Windows.Forms.FlowLayoutPanel birthday_flowPanel;
    private System.Windows.Forms.Button personalInfoOk_btn;
    private System.Windows.Forms.Label email_lbl;
    private System.Windows.Forms.TextBox email_tb;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox login_tb;
    private System.Windows.Forms.TextBox password_tb;
    private System.Windows.Forms.TextBox sex_tb;
    private System.Windows.Forms.TextBox age_tb;
  }
}