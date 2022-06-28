using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_Model
{
    public class Pushbutton : SiemensMobile
    {
        public int Weight { get; set; }
        public int Endurance { get; set; }
        public override string ToString()
        {
            return "Код модели: " + ModelNumber + "\nЗарядка: " + Charging + "\nБаланс: " + Balance
                + "Вес: " + Weight + "Прочность: " + Endurance;
        }
        public void ThrowPhoneInSomeone()
        {
            if (Weight >= 200)
                MessageBox.Show("Вы кинули телефон и убили кого-то");
            else
                MessageBox.Show("Вы кинули телефон и ранили кого-то");
        }
        public void TryToBreak()
        {
            if (Weight >= 90)
                MessageBox.Show("Телефон прошёл краштест");
            else
                MessageBox.Show("Телефон не прошёл краштест");
        }
    }
}
