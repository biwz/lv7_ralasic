using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_ralasic
{
    class BubbleSort :SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arraySize = array.Length;
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = 0; j < arraySize - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
    }
}
