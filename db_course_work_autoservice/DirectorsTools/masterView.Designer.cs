namespace db_course_work_autoservice.DirectorsTools
{
  partial class MasterView
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.delete_btn = new System.Windows.Forms.Button();
      this.id_master_tb = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.salary_tb = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.qualification_tb = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 124);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(704, 352);
      this.dataGridView1.TabIndex = 21;
      // 
      // delete_btn
      // 
      this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.delete_btn.Location = new System.Drawing.Point(193, 88);
      this.delete_btn.Name = "delete_btn";
      this.delete_btn.Size = new System.Drawing.Size(161, 29);
      this.delete_btn.TabIndex = 20;
      this.delete_btn.Text = "Уволить";
      this.delete_btn.UseVisualStyleBackColor = true;
      this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
      // 
      // id_master_tb
      // 
      this.id_master_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.id_master_tb.Location = new System.Drawing.Point(12, 89);
      this.id_master_tb.Name = "id_master_tb";
      this.id_master_tb.Size = new System.Drawing.Size(175, 29);
      this.id_master_tb.TabIndex = 19;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(8, 65);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(87, 21);
      this.label4.TabIndex = 18;
      this.label4.Text = "ID мастера";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(374, 33);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(161, 29);
      this.button1.TabIndex = 17;
      this.button1.Text = "Нанять";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // salary_tb
      // 
      this.salary_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.salary_tb.Location = new System.Drawing.Point(193, 33);
      this.salary_tb.Name = "salary_tb";
      this.salary_tb.Size = new System.Drawing.Size(175, 29);
      this.salary_tb.TabIndex = 16;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(189, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(76, 21);
      this.label3.TabIndex = 15;
      this.label3.Text = "Зарплата";
      // 
      // qualification_tb
      // 
      this.qualification_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.qualification_tb.Location = new System.Drawing.Point(12, 33);
      this.qualification_tb.Name = "qualification_tb";
      this.qualification_tb.Size = new System.Drawing.Size(175, 29);
      this.qualification_tb.TabIndex = 14;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(8, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 21);
      this.label2.TabIndex = 13;
      this.label2.Text = "Квалификация";
      // 
      // MasterView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(756, 489);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.delete_btn);
      this.Controls.Add(this.id_master_tb);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.salary_tb);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.qualification_tb);
      this.Controls.Add(this.label2);
      this.Name = "MasterView";
      this.Text = "masterView";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button delete_btn;
    private System.Windows.Forms.TextBox id_master_tb;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox salary_tb;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox qualification_tb;
    private System.Windows.Forms.Label label2;
  }
}