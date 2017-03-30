using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class TaschenrechnerForm : Form
    {
        Double wert = 0;
        String operation = "";
        bool zeichen = false;

        public TaschenrechnerForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((ausgabeTextBox.Text == "0") || (zeichen))
                ausgabeTextBox.Clear();
            Button b = (Button)sender;
            ausgabeTextBox.Text = ausgabeTextBox.Text + b.Text;
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            ausgabeTextBox.Text = "0";
        }

        private void zeichen_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            wert = Convert.ToDouble(ausgabeTextBox.Text);
            zeichen = true;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    ausgabeTextBox.Text = (wert + Convert.ToDouble(ausgabeTextBox.Text)).ToString();
                    break;
                case "-":
                    ausgabeTextBox.Text = (wert - Convert.ToDouble(ausgabeTextBox.Text)).ToString();
                    break;
                case "*":
                    ausgabeTextBox.Text = (wert * Convert.ToDouble(ausgabeTextBox.Text)).ToString();
                    break;
                case  "/":
                    ausgabeTextBox.Text = (wert / Convert.ToDouble(ausgabeTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            zeichen = false;
        }
    }
}
