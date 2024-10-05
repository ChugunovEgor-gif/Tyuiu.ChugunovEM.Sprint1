using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChugunovEM.Sprint1.Task1.V21.Lib
{
    public class DataService : ISprint1Task0V21
    {
        public double Calculate(double x, double y)
        {
            return x / (1 - y);
        }

        public double Calculate()
        {
            throw new NotImplementedException();
        }
    }

}