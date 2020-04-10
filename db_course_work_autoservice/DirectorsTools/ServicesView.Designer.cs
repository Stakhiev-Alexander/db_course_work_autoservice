namespace db_course_work_autoservice.DirectorsTools
{
  partial class ServicesView
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
      this.id_service_tb = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.add_btn = new System.Windows.Forms.Button();
      this.price_tb = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.name_tb = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.qualification_tb = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 120);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(704, 352);
      this.dataGridView1.TabIndex = 30;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // delete_btn
      // 
      this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.delete_btn.Location = new System.Drawing.Point(193, 84);
      this.delete_btn.Name = "delete_btn";
      this.delete_btn.Size = new System.Drawing.Size(161, 29);
      this.delete_btn.TabIndex = 29;
      this.delete_btn.Text = "Удалить";
      this.delete_btn.UseVisualStyleBackColor = true;
      this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
      // 
      // id_service_tb
      // 
      this.id_service_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.id_service_tb.Location = new System.Drawing.Point(12, 85);
      this.id_service_tb.Name = "id_service_tb";
      this.id_service_tb.Size = new System.Drawing.Size(175, 29);
      this.id_service_tb.TabIndex = 28;
      this.id_service_tb.TextChanged += new System.EventHandler(this.id_master_tb_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(8, 61);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 21);
      this.label4.TabIndex = 27;
      this.label4.Text = "ID услуги";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // add_btn
      // 
      this.add_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.add_btn.Location = new System.Drawing.Point(558, 29);
      this.add_btn.Name = "add_btn";
      this.add_btn.Size = new System.Drawing.Size(161, 29);
      this.add_btn.TabIndex = 26;
      this.add_btn.Text = "Добавить";
      this.add_btn.UseVisualStyleBackColor = true;
      this.add_btn.Click += new System.EventHandler(this.button1_Click);
      // 
      // price_tb
      // 
      this.price_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.price_tb.Location = new System.Drawing.Point(193, 29);
      this.price_tb.Name = "price_tb";
      this.price_tb.Size = new System.Drawing.Size(175, 29);
      this.price_tb.TabIndex = 25;
      this.price_tb.TextChanged += new System.EventHandler(this.salary_tb_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(189, 5);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(87, 21);
      this.label3.TabIndex = 24;
      this.label3.Text = "Стоимость";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // name_tb
      // 
      this.name_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.name_tb.Location = new System.Drawing.Point(12, 29);
      this.name_tb.Name = "name_tb";
      this.name_tb.Size = new System.Drawing.Size(175, 29);
      this.name_tb.TabIndex = 23;
      this.name_tb.TextChanged += new System.EventHandler(this.qualification_tb_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(8, 5);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(117, 21);
      this.label2.TabIndex = 22;
      this.label2.Text = "Наименование";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(370, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(115, 21);
      this.label1.TabIndex = 24;
      this.label1.Text = "Квалификация";
      this.label1.Click += new System.EventHandler(this.label3_Click);
      // 
      // qualification_tb
      // 
      this.qualification_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.qualification_tb.Location = new System.Drawing.Point(374, 29);
      this.qualification_tb.Name = "qualification_tb";
      this.qualification_tb.Size = new System.Drawing.Size(175, 29);
      this.qualification_tb.TabIndex = 25;
      this.qualification_tb.TextChanged += new System.EventHandler(this.salary_tb_TextChanged);
      // 
      // ServicesView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(731, 478);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.delete_btn);
      this.Controls.Add(this.id_service_tb);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.add_btn);
      this.Controls.Add(this.qualification_tb);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.price_tb);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.name_tb);
      this.Controls.Add(this.label2);
      this.Name = "ServicesView";
      this.Text = "ServicesView";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button delete_btn;
    private System.Windows.Forms.TextBox id_service_tb;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button add_btn;
    private System.Windows.Forms.TextBox price_tb;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox name_tb;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox qualification_tb;
  }
}