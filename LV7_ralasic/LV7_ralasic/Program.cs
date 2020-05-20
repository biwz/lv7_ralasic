using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_ralasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] array = new double[] { 0, 5, 4, 2, 38, -7, 26, 142.1, -142.01, -134.02 };
            //NumberSequence sequence = new NumberSequence(array);
            //BubbleSort bubbleSort = new BubbleSort();
            //CombSort combSort = new CombSort();
            //sequence.SetSortStrategy(bubbleSort);

            //Console.WriteLine("Prije:\n" + sequence.ToString());
            //sequence.Sort();
            //Console.WriteLine("Poslije:\n" + sequence.ToString());

            //sequence.SetSortStrategy(combSort);
            //sequence.InsertAt(1, 99);
            //Console.WriteLine("Prije:\n" + sequence.ToString());
            //sequence.Sort();
            //Console.WriteLine("Poslije:\n" + sequence.ToString());

            //LinearSearch linearSearch = new LinearSearch();
            //sequence.SetSearchStrategy(linearSearch);
            //Console.WriteLine(sequence.Search(99));

            SystemDataProvider dataProvider = new SystemDataProvider();
            FileLogger fileLogger = new FileLogger("log.txt");
            ConsoleLogger consoleLogger = new ConsoleLogger();
            dataProvider.Attach(consoleLogger);
            dataProvider.Attach(fileLogger);

            while (true)
            {
                dataProvider.GetCPULoad();
                dataProvider.GetAvailableRAM();

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
