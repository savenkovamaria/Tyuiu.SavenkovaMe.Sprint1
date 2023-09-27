using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SavenkovaME.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            char[] chvalue = value.ToCharArray();
            Array.Reverse(chvalue);
            string resvalue = new string(chvalue);
            bool res = true;
            if (value==resvalue)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
