using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
        }

        private void tipBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(tipBox.Text);
                tipBox.Enabled = true;
            }
            catch
            {
                tipBox.Enabled = false;
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            double d;
            inputBox.Enabled = Double.TryParse(inputBox.Text, out d);
            outputBox.Text = (Double.Parse(inputBox.Text) * Double.Parse(tipBox.Text)).ToString();
        }
    }
}
