namespace Calculeaza_suma
{
  partial class Form1
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
      this.number1_textBox = new System.Windows.Forms.TextBox();
      this.result_textBox = new System.Windows.Forms.TextBox();
      this.numar2_textBox = new System.Windows.Forms.TextBox();
      this.number1_label = new System.Windows.Forms.Label();
      this.number2_label = new System.Windows.Forms.Label();
      this.result_label = new System.Windows.Forms.Label();
      this.sum_button = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // number1_textBox
      // 
      this.number1_textBox.Location = new System.Drawing.Point(12, 25);
      this.number1_textBox.Name = "number1_textBox";
      this.number1_textBox.Size = new System.Drawing.Size(100, 20);
      this.number1_textBox.TabIndex = 0;
      this.number1_textBox.TextChanged += new System.EventHandler(this.number_textBox_TextChanged);
      // 
      // result_textBox
      // 
      this.result_textBox.Location = new System.Drawing.Point(124, 129);
      this.result_textBox.Name = "result_textBox";
      this.result_textBox.ReadOnly = true;
      this.result_textBox.Size = new System.Drawing.Size(100, 20);
      this.result_textBox.TabIndex = 1;
      // 
      // numar2_textBox
      // 
      this.numar2_textBox.Location = new System.Drawing.Point(12, 67);
      this.numar2_textBox.Name = "numar2_textBox";
      this.numar2_textBox.Size = new System.Drawing.Size(100, 20);
      this.numar2_textBox.TabIndex = 2;
      this.numar2_textBox.TextChanged += new System.EventHandler(this.number_textBox_TextChanged);
      // 
      // number1_label
      // 
      this.number1_label.AutoSize = true;
      this.number1_label.Location = new System.Drawing.Point(12, 9);
      this.number1_label.Name = "number1_label";
      this.number1_label.Size = new System.Drawing.Size(53, 13);
      this.number1_label.TabIndex = 3;
      this.number1_label.Text = "Number 1";
      // 
      // number2_label
      // 
      this.number2_label.AutoSize = true;
      this.number2_label.Location = new System.Drawing.Point(12, 51);
      this.number2_label.Name = "number2_label";
      this.number2_label.Size = new System.Drawing.Size(53, 13);
      this.number2_label.TabIndex = 4;
      this.number2_label.Text = "Number 2";
      // 
      // result_label
      // 
      this.result_label.AutoSize = true;
      this.result_label.Location = new System.Drawing.Point(72, 132);
      this.result_label.Name = "result_label";
      this.result_label.Size = new System.Drawing.Size(37, 13);
      this.result_label.TabIndex = 5;
      this.result_label.Text = "Result";
      // 
      // sum_button
      // 
      this.sum_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sum_button.Location = new System.Drawing.Point(150, 25);
      this.sum_button.Name = "sum_button";
      this.sum_button.Size = new System.Drawing.Size(93, 62);
      this.sum_button.TabIndex = 6;
      this.sum_button.Text = "Sum";
      this.sum_button.UseVisualStyleBackColor = true;
      this.sum_button.Click += new System.EventHandler(this.suma_button_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(268, 161);
      this.Controls.Add(this.sum_button);
      this.Controls.Add(this.result_label);
      this.Controls.Add(this.number2_label);
      this.Controls.Add(this.number1_label);
      this.Controls.Add(this.numar2_textBox);
      this.Controls.Add(this.result_textBox);
      this.Controls.Add(this.number1_textBox);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox number1_textBox;
    private System.Windows.Forms.TextBox result_textBox;
    private System.Windows.Forms.TextBox numar2_textBox;
    private System.Windows.Forms.Label number1_label;
    private System.Windows.Forms.Label number2_label;
    private System.Windows.Forms.Label result_label;
    private System.Windows.Forms.Button sum_button;


  }
}

