using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Model
{
    // Для интерфейса необходимо определить 1 свойство и 2 метода. 
    // Абстрактный класс должен содержать 3-5 свойств и 3-5 методов
    // Класс должен содержать дополнительно 2 свойства и 2 метода.
    // 5.  interface Mobile -> abstract class Siemens Mobile -> class Model

    public interface IMobile
    {
        int Charging { get; set; }
        void ChargeMobile();
        bool TurnOffOrOn(bool action);

    }
    public abstract class SiemensMobile : IMobile
    {
        public int Charging { get; set; }
        public abstract void ChargeMobile();
        public abstract bool TurnOffOrOn(bool action);

        public bool ConnectionToInternet { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public abstract void Call();
        public abstract void PlayGame();
        public abstract void ConnectToInternet();
    }
    public class Model : SiemensMobile
    {

        public int Price { get; set; }
        public int Weight { get; set; }
        public Model()
        {
            Charging = 100;
            Balance = 250;
            Name = "Siemens Mobile Model ***";
            ConnectionToInternet = true;
            Price = 7000;
            Weight = 150;
        }
        public Model(int _balance, string _name, bool internet, int _price, int _weight)
        {
            Charging = 100;
            Balance = _balance;
            Name = _name;
            ConnectionToInternet = internet;
            Price = _price;
            Weight = _weight;
        }
        public void ThrowPhoneInSomeone(string target)
        {
            if (Weight >= 200)
                MessageBox.Show("Вы кинули телефон в " + target + " и убили " + target);
            else
                MessageBox.Show("Вы кинули телефон в " + target + " и ранили " + target);
        }
        public void SellPhone()
        {
            MessageBox.Show("Вы продали телефон за " + Price + " рублей");
        }
        public void PutMoneyOnBalance(int ammount)
        {
            Balance += ammount;
            MessageBox.Show("Баланс пополнен");
        }
        public override void ConnectToInternet()
        {
            MessageBox.Show("Вы подключились к интернету");
            Balance -= 125;
            Charging -= 10;
        }
        public override void ChargeMobile()
        {
            MessageBox.Show("Зарядка");
            Charging = 100;
        }
        public override void Call()
        {
            MessageBox.Show("Вы позвонили");
            Balance -= 25;
            Charging -= 5;
        }
        public override void PlayGame()
        {
            MessageBox.Show("Вы поиграли в игру");
            Charging -= 15;
        }
        public override bool TurnOffOrOn(bool action)
        {
            if (action)
            {
                MessageBox.Show("Телефон включен");
                return true;
            }
            else
            {
                MessageBox.Show("Телефон выключен");
                return false;
            }
        }
    }
}
