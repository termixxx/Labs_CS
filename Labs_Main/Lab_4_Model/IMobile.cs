using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Model
{
    public interface IMobile
    {
        int Charging { get; set; }
        void ChargeMobile();
        void TurnOffOrOn(int action);
    }
}
