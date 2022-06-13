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
    public partial class InputForm1 : Form
    {
        public string name;
        public int count;
        public double price;
        public InputForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            count = int.Parse(textBox2.Text);
            price = double.Parse(textBox3.Text);
            this.Close();
        }
    }
}
