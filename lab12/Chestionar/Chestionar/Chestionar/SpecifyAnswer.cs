using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chestionar
{
  public partial class SpecifyAnswer : Form
  {
    public SpecifyAnswer()
    {
      InitializeComponent();
    }

    private void SpecifyAnswer_Load(object sender, EventArgs e)
    {
      label1.Text = "What is the capital of Germany?";
    }

    private void verify_button_Click(object sender, EventArgs e)
    {
      if (answer_textBox.Text.ToLower() == "berlin")
        MessageBox.Show("You are right!");
      else
        MessageBox.Show("You are wrong!");

            answer_textBox.Text = "";
    }
  }
}
