using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task taskA = new Task(() => plus());
            taskA.Start();
            Console.ReadLine();
        }

        static void plus() {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

        }
    }
}
