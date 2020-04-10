namespace db_course_work_autoservice.ClientTools
{
  partial class AddWorkForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.car_id_cb = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.services_cb = new System.Windows.Forms.ComboBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 53);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(126, 21);
      this.label1.TabIndex = 0;
      this.label1.Text = "Номер машины:";
      // 
      // car_id_cb
      // 
      this.car_id_cb.FormattingEnabled = true;
      this.car_id_cb.Location = new System.Drawing.Point(181, 56);
      this.car_id_cb.Margin = new System.Windows.Forms.Padding(10);
      this.car_id_cb.Name = "car_id_cb";
      this.car_id_cb.Size = new System.Drawing.Size(383, 21);
      this.car_id_cb.TabIndex = 14;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(12, 99);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 21);
      this.label2.TabIndex = 1;
      this.label2.Text = "Услуга:";
      // 
      // services_cb
      // 
      this.services_cb.FormattingEnabled = true;
      this.services_cb.Location = new System.Drawing.Point(181, 102);
      this.services_cb.Margin = new System.Windows.Forms.Padding(10);
      this.services_cb.Name = "services_cb";
      this.services_cb.Size = new System.Drawing.Size(383, 21);
      this.services_cb.TabIndex = 15;
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 21;
      this.listBox1.Location = new System.Drawing.Point(12, 136);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(334, 277);
      this.listBox1.TabIndex = 16;
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Top;
      this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(0, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(586, 40);
      this.label3.TabIndex = 17;
      this.label3.Text = "Выберите машину и услуги";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(352, 136);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(212, 29);
      this.button1.TabIndex = 18;
      this.button1.Text = "Добавить услугу в список";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button2.Location = new System.Drawing.Point(362, 384);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(212, 29);
      this.button2.TabIndex = 19;
      this.button2.Text = "Создать заказ";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // AddWorkForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(586, 421);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.services_cb);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.car_id_cb);
      this.Controls.Add(this.label1);
      this.Name = "AddWorkForm";
      this.Text = "AddWorkForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddWorkForm_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox car_id_cb;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox services_cb;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}