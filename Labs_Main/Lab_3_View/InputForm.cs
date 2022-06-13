using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_View
{
    public partial class InputForm : Form
    {
        public string name;
        public bool internetcon;
        public int price;
        public int weight;
        public InputForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name = textBox3.Text;
            internetcon = bool.Parse(textBox4.Text);
            price = int.Parse(textBox5.Text);
            weight = int.Parse(textBox6.Text);
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //не нужно
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = null;
            textBox4.ForeColor = Color.Black;
        }
    }
}
