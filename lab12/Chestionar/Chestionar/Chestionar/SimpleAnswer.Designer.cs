namespace Chestionar
{
  partial class SimpleAnswer
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
      this.yes_button = new System.Windows.Forms.Button();
      this.no_button = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      // 
      // yes_button
      // 
      this.yes_button.Location = new System.Drawing.Point(12, 78);
      this.yes_button.Name = "yes_button";
      this.yes_button.Size = new System.Drawing.Size(75, 23);
      this.yes_button.TabIndex = 1;
      this.yes_button.Text = "Yes";
      this.yes_button.UseVisualStyleBackColor = true;
      this.yes_button.Click += new System.EventHandler(this.yes_button_Click);
      // 
      // no_button
      // 
      this.no_button.Location = new System.Drawing.Point(197, 78);
      this.no_button.Name = "no_button";
      this.no_button.Size = new System.Drawing.Size(75, 23);
      this.no_button.TabIndex = 2;
      this.no_button.Text = "No";
      this.no_button.UseVisualStyleBackColor = true;
      this.no_button.Click += new System.EventHandler(this.no_button_Click);
      // 
      // SimpleAnswer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 113);
      this.Controls.Add(this.no_button);
      this.Controls.Add(this.yes_button);
      this.Controls.Add(this.label1);
      this.Name = "SimpleAnswer";
      this.Text = "SimpleAnswer";
      this.Load += new System.EventHandler(this.SimpleAnswer_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button yes_button;
    private System.Windows.Forms.Button no_button;
  }
}