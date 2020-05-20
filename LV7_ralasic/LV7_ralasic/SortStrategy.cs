using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_ralasic
{
    abstract class SortStrategy
    {
        public abstract void Sort(double[] array);
        protected void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}
