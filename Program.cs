using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое число");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите действие: \n1) +\n2) -\n3) *\n4) /");
            int vari = int.Parse(Console.ReadLine());
            switch (vari)
            {
                case 1:
                    pluss(A, B);
                    break;
                case 2:
                    minus(A, B);
                    break;
                case 3:
                    multy(A, B);
                    break;
                case 4:
                    devide(A, B);
                    break;
            }

            void minus(int a, int b)
            {
                Console.WriteLine(a - b);
            }
        }
    }
}
