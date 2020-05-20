using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_ralasic
{
    class LinearSearch : ISearchStrategy
    {
        public int Search(double number, double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return i;
            }
            return -1;
        }
    }
}
