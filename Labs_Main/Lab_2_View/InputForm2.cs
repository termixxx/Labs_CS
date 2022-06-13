using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_View
{
    public partial class InputForm2 : Form
    {
        public string name;
        public int count;
        public double price;
        public int year;
        public InputForm2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // не нужно
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // не нужно
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            count = int.Parse(textBox2.Text);
            price = double.Parse(textBox3.Text);
            year = int.Parse(textBox4.Text);
            this.Close();
        }
    }
}
