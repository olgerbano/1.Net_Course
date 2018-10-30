using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculeaza_suma
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void suma_button_Click(object sender, EventArgs e)
    {
      try
      {
        string str;
        int number1, number2;

        str = number1_textBox.Text;
        number1 = int.Parse(str);
        str = numar2_textBox.Text;
        number2 = int.Parse(str);

        int suma = number1 + number2;
        result_textBox.Text = suma.ToString();
      }
      catch (Exception exc)
      {
        MessageBox.Show("Valorile celor 2 numere nu pot fi citite");
      }
    }
    private void number_textBox_TextChanged(object sender, EventArgs e)
    {
      result_textBox.Text = "";
    }
  }
}
