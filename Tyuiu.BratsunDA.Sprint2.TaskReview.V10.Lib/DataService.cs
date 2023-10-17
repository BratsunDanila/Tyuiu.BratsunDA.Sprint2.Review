using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BratsunDA.Sprint2.TaskReview.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool a = (y >= x * x - 2);
            bool b = (y <= x);
            bool c = (y <= -x);
            if (a && b && c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}