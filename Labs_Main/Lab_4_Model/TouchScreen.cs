using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_Model
{
    public class TouchScreen : SiemensMobile
    {
        public double Diagonal { get; set; }
        public int Pixel { get; set; }
        public override string ToString()
        {
            return "Код модели: " + ModelNumber + "\nЗарядка: " + Charging + "\nБаланс: " + Balance
                + "Размер экрана: " + Diagonal + "Плотность пикселей пикселей: " + Pixel;
        }
        public void WatchFilm()
        {
            if (Diagonal >= 6)
                MessageBox.Show("Вы с комфортом посмотрели фильм");
            else
                MessageBox.Show("Вы не стали смотреть фильм из-за маленького экрана");
        }
        public void CheckQuality()
        {
            if (Pixel <= 150)
                MessageBox.Show("Плохое качество экрана");
            else if (Pixel <= 250)
                MessageBox.Show("Среднее качество экрана");
            else
                MessageBox.Show("Отличное качество экрана");
        }
    }
}
