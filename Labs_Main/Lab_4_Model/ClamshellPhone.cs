using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_Model
{
    public class ClamshellPhone : SiemensMobile
    {
        public int NumberOfFolds { get; set; }
        public int MaxNumberOfFolds { get; set; }
        public override string ToString()
        {
            return "Код модели: " + ModelNumber + "\nЗарядка: " + Charging + "\nБаланс: " + Balance
                + "Количество складываний: " + NumberOfFolds + "Максимальное количество складываний: " + MaxNumberOfFolds;
        }
        public void OpenPhone()
        {
            if (NumberOfFolds <= MaxNumberOfFolds)
            {
                MessageBox.Show("Телефон открылся");
                NumberOfFolds++;
            }
            else
                MessageBox.Show("Крышка телефона достигла максимального числа открытий");
        }
        public void FixShell()
        {
            MaxNumberOfFolds+=10;
            MessageBox.Show("Крышка немного починена");
        }
    }
}
