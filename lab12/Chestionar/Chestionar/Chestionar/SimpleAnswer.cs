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
  public partial class SimpleAnswer : Form
  {
    public SimpleAnswer()
    {
      InitializeComponent();
    }

    private void SimpleAnswer_Load(object sender, EventArgs e)
    {
      label1.Text = "Is it true that the Earth spinns arround the Moon?";
    }

    private void yes_button_Click(object sender, EventArgs e)
    {
      MessageBox.Show("You have answered wrong.");
    }

    private void no_button_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Your answer is correct");
    }
  }
}
