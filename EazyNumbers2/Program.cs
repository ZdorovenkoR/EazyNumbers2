using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            int i = 2;
            if (i < n)
            {
                Conv1(n, i, d); //проверка i<n
            }
            else
            {
                Conv2(d); // Проверка d==0
            }
        }
        public int Conv1(int n, int i, int d)//первая проерка на блок схеме
        {
            if (n%i==0)
            {
                d++;
                i++;
                Conv1(n, i, d);
            }
            else
            {
                i++;
                Conv1(n, i, d);
            }
        }
        public int Conv2 (int d) //вторая проекра на блок схеме
        {
            if (d == 0)
            {
                Console.WriteLine("простое");
            }
            else
            {
                Console.WriteLine("не простое");
            }
        }
    }
}
