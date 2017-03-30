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

            zeichen = false;
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if(!ausgabeTextBox.Text.Contains(","))
                    ausgabeTextBox.Text = ausgabeTextBox.Text + b.Text;
            }
            else
                ausgabeTextBox.Text = ausgabeTextBox.Text + b.Text;
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            ausgabeTextBox.Text = "0";
        }

        private void zeichen_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (wert != 0)
            {
                enterButton.PerformClick();
                zeichen = true;
                operation = b.Text;
                operationLabel.Text = wert + " " + operation;

            }
            else

            operation = b.Text;
            wert = Convert.ToDouble(ausgabeTextBox.Text);
            zeichen = true;
            operationLabel.Text = wert + " " + operation;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "";
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
            wert = Convert.ToInt32(ausgabeTextBox.Text);
            operation = "";
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            ausgabeTextBox.Text = "0";
            wert = 0;
            operationLabel.Text = "";
        }

        private void TaschenrechnerForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "0":
                    nullButton.PerformClick();
                    break;
                case "1":
                    einsButton.PerformClick();
                    break;
                case "2":
                    zweiButton.PerformClick();
                    break;
                case "3":
                    dreiButton.PerformClick();
                    break;
                case "4":
                    vierButton.PerformClick();
                    break;
                case "5":
                    fünfButton.PerformClick();
                    break;
                case "6":
                    sechsButton.PerformClick();
                    break;
                case "7":
                    siebenButton.PerformClick();
                    break;
                case "8":
                    achtButton.PerformClick();
                    break;
                case "9":
                    neunButton.PerformClick();
                    break;
                case "+":
                    plusButton.PerformClick();
                    break;
                case "-":
                    minusButton.PerformClick();
                    break;
                case "*":
                    malButton.PerformClick();
                    break;
                case "/":
                    geteiltButton.PerformClick();
                    break;
                case "enter":
                    enterButton.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
