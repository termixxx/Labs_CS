using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_Model
{
    public abstract class SiemensMobile : IMobile
    {

        public int Charging { get; set; }
        public void ChargeMobile()
        {
            MessageBox.Show("Зарядка");
            Charging = 100;
        }
        public void TurnOffOrOn(int action)
        {
            if (action == 1) 
                MessageBox.Show("Телефон включен");
            else
                MessageBox.Show("Телефон выключен");
        }

        public int Balance { get; set; }
        public int ModelNumber { get; set; }
        public void Call()
        {
            MessageBox.Show("Вы позвонили");
            Balance -= 25;
            Charging -= 5;
        }
        public void PlayGame()
        {
            MessageBox.Show("Вы поиграли в игру");
            Charging -= 15;
        }
        public void ConnectToInternet()
        {
            MessageBox.Show("Вы подключились к интернету");
            Balance -= 125;
            Charging -= 10;
        }
    }
}
