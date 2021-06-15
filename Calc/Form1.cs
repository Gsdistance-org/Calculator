using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calc.Calc;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void error()
        {
            MessageBox.Show("ERROR");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num11 = (Convert.ToDouble(this.richTextBox1.Text));
                double num22 = (Convert.ToDouble(this.richTextBox3.Text));
                string lus = (Convert.ToString(this.richTextBox2.Text));
                if (lus == "+")
                {
                    string answer = (Convert.ToString(Calc.add(num11, num22)));
                    MessageBox.Show(answer);
                }
                else if (lus == "-")
                {
                   string answer = (Convert.ToString(Calc.subtract(num11, num22)));
                    MessageBox.Show(answer);
                }
                else if (lus == "*")
                {
                    string answer = (Convert.ToString(Calc.multiply(num11, num22)));
                    MessageBox.Show(answer);
                }
                else if (lus == "/")
                {
                    string answer = (Convert.ToString(Calc.divide(num11, num22)));
                    MessageBox.Show(answer);
                }
            }
            catch(Exception ex)
            {
                error();
            }
            finally
            {

            }
        }
    }
}
