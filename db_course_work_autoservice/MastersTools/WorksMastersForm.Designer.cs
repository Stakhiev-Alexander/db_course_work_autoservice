namespace db_course_work_autoservice.MastersTools
{
  partial class WorksMastersForm
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
      this.end_btn = new System.Windows.Forms.Button();
      this.id_work_tb = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 65);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(776, 373);
      this.dataGridView1.TabIndex = 25;
      // 
      // end_btn
      // 
      this.end_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.end_btn.Location = new System.Drawing.Point(193, 29);
      this.end_btn.Name = "end_btn";
      this.end_btn.Size = new System.Drawing.Size(161, 29);
      this.end_btn.TabIndex = 24;
      this.end_btn.Text = "Завершить";
      this.end_btn.UseVisualStyleBackColor = true;
      this.end_btn.Click += new System.EventHandler(this.end_btn_Click);
      // 
      // id_work_tb
      // 
      this.id_work_tb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.id_work_tb.Location = new System.Drawing.Point(12, 30);
      this.id_work_tb.Name = "id_work_tb";
      this.id_work_tb.Size = new System.Drawing.Size(175, 29);
      this.id_work_tb.TabIndex = 23;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(8, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(75, 21);
      this.label4.TabIndex = 22;
      this.label4.Text = "ID заказа";
      // 
      // WorksMastersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.end_btn);
      this.Controls.Add(this.id_work_tb);
      this.Controls.Add(this.label4);
      this.Name = "WorksMastersForm";
      this.Text = "WorksMastersForm";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button end_btn;
    private System.Windows.Forms.TextBox id_work_tb;
    private System.Windows.Forms.Label label4;
  }
}