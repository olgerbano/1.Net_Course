namespace Chestionar
{
  partial class MainForm
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
      this.simpleAnswer_button = new System.Windows.Forms.Button();
      this.specifyAnswer_button = new System.Windows.Forms.Button();
      this.description_label = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // simpleAnswer_button
      // 
      this.simpleAnswer_button.Location = new System.Drawing.Point(12, 95);
      this.simpleAnswer_button.Name = "simpleAnswer_button";
      this.simpleAnswer_button.Size = new System.Drawing.Size(120, 23);
      this.simpleAnswer_button.TabIndex = 0;
      this.simpleAnswer_button.Text = "Simple answer";
      this.simpleAnswer_button.UseVisualStyleBackColor = true;
      this.simpleAnswer_button.Click += new System.EventHandler(this.simpleAnswer_button_Click);
      // 
      // specifyAnswer_button
      // 
      this.specifyAnswer_button.Location = new System.Drawing.Point(151, 95);
      this.specifyAnswer_button.Name = "specifyAnswer_button";
      this.specifyAnswer_button.Size = new System.Drawing.Size(120, 23);
      this.specifyAnswer_button.TabIndex = 1;
      this.specifyAnswer_button.Text = "Specify answer";
      this.specifyAnswer_button.UseVisualStyleBackColor = true;
      this.specifyAnswer_button.Click += new System.EventHandler(this.specifyAnswer_button_Click);
      // 
      // description_label
      // 
      this.description_label.Location = new System.Drawing.Point(12, 9);
      this.description_label.Name = "description_label";
      this.description_label.Size = new System.Drawing.Size(260, 76);
      this.description_label.TabIndex = 2;
      this.description_label.Text = "There are 2 types of questions:\r\n* In the simple answer question you may chose be" +
    "tween Yes or No\r\n* In the specity answer question there is a field where the ans" +
    "wer can be entered manually.";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 130);
      this.Controls.Add(this.description_label);
      this.Controls.Add(this.specifyAnswer_button);
      this.Controls.Add(this.simpleAnswer_button);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button simpleAnswer_button;
    private System.Windows.Forms.Button specifyAnswer_button;
    private System.Windows.Forms.Label description_label;
  }
}

