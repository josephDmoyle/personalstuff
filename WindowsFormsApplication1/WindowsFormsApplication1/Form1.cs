using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            string billstr = billTextBox.Text;
            double bill = 0;
            try
            {
                bill = Convert.ToDouble(billstr);
                bill *= 1.2;
                resultTextBox.Text = "" + bill;
                return;
            }
            catch (Exception)
            {
                resultTextBox.Text = "Invalid Bill";
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void billTextBox_TextChanged(object sender, EventArgs e)
        {
            string billstr = billTextBox.Text;
            double bill = 0;
            double tip = 1;
            double tipAmount = 0;
            try
            {
                bill = Convert.ToDouble(billstr);
                if(percentageTextBox.Text == "")
                {
                    tip = 0;
                }
                else
                {
                    tip = Convert.ToDouble(percentageTextBox.Text) *.01;
                }
                tipAmount = bill * tip;
                tipBox.Text = "" + tipAmount.ToString("N2");
                bill = bill + bill * tip;
                resultTextBox.Text = "" + bill.ToString("N2");
                return;
            }
            catch
            {
                resultTextBox.Text = "Invalid Bill";
                return;
            }
        }

        private void percentageTextBox_TextChanged(object sender, EventArgs e)
        {
            billTextBox_TextChanged(sender, e);
        }
    }
}
