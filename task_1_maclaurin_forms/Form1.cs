using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1_maclaurin_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox1.Text == "0" )
            {
                textBox1.Text = "1";
            }

            if ( int.Parse(textBox2.Text) < 1 )
            {
                textBox2.Text = "1";
            }

            double X = double.Parse(textBox1.Text.Replace(".", ","));
            
            int N = int.Parse(textBox2.Text);
            double LastElem = 0;

            Maclaurin maclaurin = new Maclaurin();
            double Result_1 = maclaurin.Maclaurin1(X, N, ref LastElem);
            textBox3.Text = Convert.ToString(Result_1);

            double Error = Math.Abs((Math.Sin(X) / X) - Result_1);
            textBox4.Text = Convert.ToString(Error);
            textBox5.Text = Convert.ToString( Math.Abs(Error - LastElem) );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "0")
            {
                textBox6.Text = "1";
            }

            if (double.Parse( textBox7.Text.Replace(".", ",") ) < 0)
            {
                textBox7.Text = "0.01";
            }

            double x = double.Parse( textBox6.Text.Replace(".", ",") );
            double er = double.Parse( textBox7.Text.Replace(".", ",") );
            
            Maclaurin maclaurin = new Maclaurin();

            int n1 = 0;
            double sum = maclaurin.Maclaurin2(x, er, ref n1);
            textBox8.Text = Convert.ToString(sum);
            textBox9.Text = Convert.ToString(n1);

            int n2 = 0;
            double sum2 = maclaurin.Maclaurin2(x, er * 10, ref n2);
            textBox10.Text = Convert.ToString(sum2);
            textBox11.Text = Convert.ToString(n2);
        }
    }
}
