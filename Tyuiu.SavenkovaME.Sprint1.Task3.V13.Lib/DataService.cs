using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SavenkovaME.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            var total = 1;
            string strnumber = number.ToString();
            foreach (char i in strnumber)
            {
                total = total * Convert.ToInt32(i.ToString());
            }
            return total;


        }
    }
}
