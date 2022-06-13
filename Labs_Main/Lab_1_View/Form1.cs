using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_1_Model;

//Загоровский Анатолий 9 группа

//Задача 1, номер 5 
//Создать объект класса Планета, используя классы Материк, Океан, Остров.
//Методы: вывести название материка, планеты, количество материков.

namespace Lab_1_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Planet planet = null;
        private void button4_Click(object sender, EventArgs e)
        {
            planet = new Planet(textBox4.Text);
            MessageBox.Show($"Планета {textBox4.Text} создана! Теперь добавьте материки, океаны и острова.");
            textBox4.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            pictureBox1.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Continent continent = new Continent(textBox1.Text);
            planet.AddContinent(continent);
            MessageBox.Show($"Континент {textBox1.Text} был добавлен!");

            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ocean ocean = new Ocean(textBox2.Text);
            planet.AddOcean(ocean);
            MessageBox.Show($"Океан {textBox2.Text} был добавлен!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Island island = new Island(textBox3.Text);
            planet.AddIsland(island);
            MessageBox.Show($"Остров {textBox3.Text} был добавлен!");

        }


        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Название планеты: {planet.Name}\n" +
                $"Название материков: {showContinents()}\n" +
                $"Названия океанов: {showOceans()}\n" +
                $"Названия островов: {showIslands()}");
        }

        private string showContinents()
        {
            if (planet.CountOfContinents() != 0)
            {
                string res = "";
                res += planet.GetContinents()[0].Name;
                for (int i = 1; i < planet.CountOfContinents(); i++)
                    res += ", " + planet.GetContinents()[i].Name;
                return res;
            }
            return "материков нет";
        }
        private string showOceans()
        {
            if (planet.CountOfOceans() != 0)
            {
                string res = "";
                res += planet.GetOceans()[0].Name;
                for (int i = 1; i < planet.CountOfOceans(); i++)
                    res += ", " + planet.GetOceans()[i].Name;
                return res;
            }
            return "океанов нет";
        }
        private string showIslands()
        {
            if (planet.CountOfIslands()!=0)
            {
                string res = "";
                res += planet.GetIslands()[0].Name;
                for (int i = 1; i < planet.CountOfIslands(); i++)
                    res += ", " + planet.GetIslands()[i].Name;
                return res;
            }
            return "островов нет";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Количество материков: {planet.CountOfContinents()}\n" +
                $"Количество океанов: {planet.CountOfOceans()}\n" +
                $"Названия островов: {planet.CountOfIslands()}");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
