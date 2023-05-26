using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_week3
{
    public partial class Form1 : Form
    {

        bd bd = new bd();


        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }
        Form2 form2;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            form2.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
