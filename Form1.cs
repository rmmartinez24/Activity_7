using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double terms;
            double pi = 4;
            double topNum = 4;
            double bottomNum = 3;

            terms = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i <= terms; i++)
            {
                if (i % 2 == 0)
                {
                    pi -= topNum / bottomNum;
                }

                else
                {
                    pi += topNum / bottomNum;
                }

                bottomNum += 2;
            }

            label2.Text = "Value of pi after " + terms + " terms";
            label3.Text = "= " + pi;
        }
    }
}
