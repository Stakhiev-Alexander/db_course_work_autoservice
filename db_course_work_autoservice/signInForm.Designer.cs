namespace db_course_work_autoservice
{
  partial class SignInForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
      this.signUp_lbl = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.signIn_btn = new System.Windows.Forms.Button();
      this.logPswTable = new System.Windows.Forms.TableLayoutPanel();
      this.psw_label = new System.Windows.Forms.Label();
      this.login_tb = new System.Windows.Forms.TextBox();
      this.pass_tb = new System.Windows.Forms.TextBox();
      this.login_label = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.logPswTable.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // signUp_lbl
      // 
      this.signUp_lbl.AutoSize = true;
      this.signUp_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
      this.signUp_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.signUp_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
      this.signUp_lbl.Location = new System.Drawing.Point(556, 11);
      this.signUp_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.signUp_lbl.Name = "signUp_lbl";
      this.signUp_lbl.Size = new System.Drawing.Size(137, 23);
      this.signUp_lbl.TabIndex = 7;
      this.signUp_lbl.Text = "Создать аккаунт";
      this.signUp_lbl.Click += new System.EventHandler(this.signUp_lbl_Click);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(711, 49);
      this.label1.TabIndex = 6;
      this.label1.Text = "Вход в систему";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // signIn_btn
      // 
      this.signIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.signIn_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.signIn_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.signIn_btn.Location = new System.Drawing.Point(0, 322);
      this.signIn_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.signIn_btn.Name = "signIn_btn";
      this.signIn_btn.Size = new System.Drawing.Size(711, 37);
      this.signIn_btn.TabIndex = 5;
      this.signIn_btn.Text = "Войти";
      this.signIn_btn.UseVisualStyleBackColor = true;
      this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
      // 
      // logPswTable
      // 
      this.logPswTable.ColumnCount = 2;
      this.logPswTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.15531F));
      this.logPswTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.84469F));
      this.logPswTable.Controls.Add(this.psw_label, 0, 1);
      this.logPswTable.Controls.Add(this.login_tb, 1, 0);
      this.logPswTable.Controls.Add(this.pass_tb, 1, 1);
      this.logPswTable.Controls.Add(this.login_label, 0, 0);
      this.logPswTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.logPswTable.Location = new System.Drawing.Point(111, 210);
      this.logPswTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.logPswTable.Name = "logPswTable";
      this.logPswTable.RowCount = 2;
      this.logPswTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.logPswTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.logPswTable.Size = new System.Drawing.Size(383, 78);
      this.logPswTable.TabIndex = 4;
      // 
      // psw_label
      // 
      this.psw_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.psw_label.AutoSize = true;
      this.psw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.psw_label.Location = new System.Drawing.Point(27, 46);
      this.psw_label.Name = "psw_label";
      this.psw_label.Size = new System.Drawing.Size(81, 24);
      this.psw_label.TabIndex = 1;
      this.psw_label.Text = "Пароль:";
      // 
      // login_tb
      // 
      this.login_tb.Dock = System.Windows.Forms.DockStyle.Fill;
      this.login_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.login_tb.Location = new System.Drawing.Point(111, 4);
      this.login_tb.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
      this.login_tb.Name = "login_tb";
      this.login_tb.Size = new System.Drawing.Size(272, 28);
      this.login_tb.TabIndex = 2;
      // 
      // pass_tb
      // 
      this.pass_tb.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pass_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.pass_tb.Location = new System.Drawing.Point(111, 43);
      this.pass_tb.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
      this.pass_tb.Name = "pass_tb";
      this.pass_tb.Size = new System.Drawing.Size(272, 29);
      this.pass_tb.TabIndex = 3;
      this.pass_tb.UseSystemPasswordChar = true;
      // 
      // login_label
      // 
      this.login_label.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.login_label.AutoSize = true;
      this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.login_label.Location = new System.Drawing.Point(39, 7);
      this.login_label.Name = "login_label";
      this.login_label.Size = new System.Drawing.Size(69, 24);
      this.login_label.TabIndex = 0;
      this.login_label.Text = "Логин:";
      // 
      // pictureBox1
      // 
      this.pictureBox1.ErrorImage = null;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(221, 53);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(272, 151);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // SignInForm
      // 
      this.AcceptButton = this.signIn_btn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(711, 359);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.signUp_lbl);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.signIn_btn);
      this.Controls.Add(this.logPswTable);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "SignInForm";
      this.Text = "Login";
      this.logPswTable.ResumeLayout(false);
      this.logPswTable.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label signUp_lbl;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button signIn_btn;
    private System.Windows.Forms.TableLayoutPanel logPswTable;
    private System.Windows.Forms.Label psw_label;
    private System.Windows.Forms.TextBox login_tb;
    private System.Windows.Forms.TextBox pass_tb;
    private System.Windows.Forms.Label login_label;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

