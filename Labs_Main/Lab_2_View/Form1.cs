using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_2_Model;

namespace Lab_2_View
{
    public partial class Form1 : Form
    {
        Books programmingBook;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // не нужно
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Книга имеет год издания?", "Вопрос",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                InputForm2 formWithYear = new InputForm2();
                formWithYear.Owner = this;
                formWithYear.ShowDialog();
                programmingBook = new BooksWithYear(formWithYear.name,
                    formWithYear.count, formWithYear.price, formWithYear.year);
            }
            else
            {
                InputForm1 formWithOutYear = new InputForm1();
                formWithOutYear.Owner = this;
                formWithOutYear.ShowDialog();
                programmingBook = new Books(formWithOutYear.name,
                    formWithOutYear.count, formWithOutYear.price);
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(programmingBook.GetInfo() +"\nКачество книги: "+ programmingBook.GetQuality());
        }
    }
}
