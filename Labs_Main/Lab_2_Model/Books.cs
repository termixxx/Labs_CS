using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Model
{
    public class Books
    {
        private string Name { get; set; }
        private int CountOfPages { get; set; }
        private double Price { get; set; }
        public Books(string nm, int cnt, double money)
        {
            Name = nm;
            CountOfPages = cnt;
            Price = money;
        }
        public virtual double GetQuality()
        {
            return Price / CountOfPages;
        }
        public virtual string GetInfo()
        {
            return "Название: " + Name + "\nКоличество страниц: " + CountOfPages + "\nЦена: " + Price;
        }
    }
    public class BooksWithYear : Books
    {
        private readonly int YearOfPublication;
        public BooksWithYear(string nm, int cnt, double money, int year) : base(nm, cnt, money)
        {
            YearOfPublication = year;
        }
        public override double GetQuality()
        {
            return base.GetQuality() - 0.2 * (2022 - YearOfPublication);
        }
        public override string GetInfo()
        {
            return base.GetInfo() + "\nГод издания: " + YearOfPublication;
        }
    }
}
