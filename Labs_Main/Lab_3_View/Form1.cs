using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_3_Model;

namespace Lab_3_View
{
    public partial class Form1 : Form
    {
        const bool OFF = false;
        const bool ON = true;
        Model PHONE;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (PHONE.Charging != 0)
            {
                PHONE.TurnOffOrOn(ON);
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
                MessageBox.Show("Нет зарядки");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PHONE.TurnOffOrOn(OFF);
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;
        }
        void updateInfo()
        {
            textBox1.Text = PHONE.Charging.ToString();
            textBox2.Text = PHONE.Balance.ToString();
            textBox3.Text = PHONE.Name;
            textBox4.Text = PHONE.ConnectionToInternet.ToString();
            textBox5.Text = PHONE.Price.ToString();
            textBox6.Text = PHONE.Weight.ToString();
            if (PHONE.Charging == 0)
            {
                PHONE.TurnOffOrOn(OFF);
                button4.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            InputForm infr = new InputForm();
            infr.ShowDialog();
            PHONE = new Model(250, infr.name, infr.internetcon, infr.price, infr.weight);
            button1.Enabled = true;
            updateInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PHONE.ChargeMobile();
            updateInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (PHONE.Charging >= 5)
                if (PHONE.Balance >= 25)
                {
                    PHONE.Call();
                    updateInfo();
                }
                else
                    MessageBox.Show("Недостаточно денег на балансе");
            else
                MessageBox.Show("Недостаточно зарядки");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (PHONE.Charging >= 15)
            {
                PHONE.PlayGame();
                updateInfo();
            }
            else
                MessageBox.Show("Недостаточно зарядки");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (PHONE.ConnectionToInternet)
            {
                if (PHONE.Charging >= 10)
                    if (PHONE.Balance >= 125)
                    {
                        PHONE.ConnectToInternet();
                        updateInfo();
                    }
                    else
                        MessageBox.Show("Недостаточно денег на балансе");
                else
                    MessageBox.Show("Недостаточно зарядки");
            }
            else
                MessageBox.Show("Телефон не подключен к интеренету");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PHONE.ThrowPhoneInSomeone("Человека");
            PHONE.TurnOffOrOn(OFF);
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PHONE.SellPhone();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PHONE.PutMoneyOnBalance(100);
            updateInfo();
        }
    }
}
