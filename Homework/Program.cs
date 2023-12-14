using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipoteka(1000000, 100000, 10000, 1);
            Console.WriteLine(Task1(5, 4));
            Console.Read();
        }
        static void Ipoteka(double apartmentPrice, double initialFee, double monthlyPayment, int p)
        {
            if(p == 0)
            {
                Console.WriteLine((apartmentPrice - initialFee) / monthlyPayment);
            }
            else
            {
                double debt = apartmentPrice - initialFee;
                int i = 1;
                while(debt > 0)
                {
                    debt = debt - monthlyPayment;
                    Console.WriteLine(i + " месяц, долг " + debt);
                    i++;
                }
            }
        }
        static double Task1(double g, double r)
        {
            double deltaP = (95 * Math.Pow(g, 1 / 3)) / r + (390 * Math.Pow(g * g, 1 / 3)) / Math.Pow(r, 2) + (1300 * g) / Math.Pow(r, 3);
            return deltaP;
        }
    }
}
