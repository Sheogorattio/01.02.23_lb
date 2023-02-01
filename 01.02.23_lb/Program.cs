using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace first_project
{
    internal class Program
    {
        static double fSum(params double[] args)
        {
            double s = 0;
            for (int i = 0; i < args.Length; i++) s += args[i];
            return s;
        }

        static double fProd(params double[] args)
        {
            double prod = 1;
            for (int i = 0; i < args.Length; i++) prod *= args[i];
            return prod;
        }

        static double fGetMax(params double[] args)
        {
            double max = args[0];
            for (int i = 0; i < args.Length; i++) if (args[i] > max) max = args[i];
            return max;
        }

        static double fGetMin(params double[] args)
        {
            double min = args[0];
            for (int i = 0; i < args.Length; i++) if (args[i] < min) min = args[i];
            return min;
        }
        static void Main(string[] args)
        {
            #region task 1
            Console.WriteLine("TASK 1");
            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup\n");
            #endregion
            #region task 2
            Console.WriteLine("TASK 2");
            Console.WriteLine("Enter 5 numbers");
            double a = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine()), c = Convert.ToDouble(Console.ReadLine()), d = Convert.ToDouble(Console.ReadLine()), e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Sum ={fSum(a, b, c, d, e)}");
            Console.WriteLine($"Prod = {fProd(a, b, c, d, e)}");
            Console.WriteLine($"Max = {fGetMax(a, b, c, d, e)}");
            Console.WriteLine($"Min = {fGetMin(a, b, c, d, e)}");
            #endregion
            #region task 3
            Console.WriteLine("Enter an integer number");
            int num = Convert.ToInt32(Console.ReadLine()), var = 0, res = 0; ;
            const int divider = 10;
            do
            {
                var = num % divider;
                num -= var;
                num /= 10;
                res *= divider;
                res += var;

            } while (num >= 1);
            Console.WriteLine(res);
            #endregion
            #region task 4
            Console.WriteLine("Enter min border");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max border");
            int max = Convert.ToInt32(Console.ReadLine());
            if (0 >= min && min <= max)
            {
                Console.Write("0\t");
                int num1 = 0, num2 = 1, sum = 0;
                while (true)
                {
                    if (num2 <= max)
                    {
                        Console.Write($"{num2}\t");
                        sum = num2 + num1;
                        num1 = num2;
                        num2 = sum;
                    }
                    else break;
                }
            }
            #endregion
            #region task 5
            Console.WriteLine("Enter A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B");
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
            #endregion
            #region task 6
            Console.WriteLine("print line manual\nprint line -symbol -lenght -direction\nDiretion:\t-hor/-vert\nEnter command...");
            string str = Console.ReadLine();
            char symbol=' ', direction= ' ';
            int lenght = 0;
            if(str.IndexOf("print line -") == 0)
            {
                symbol = str["print line -".Length];
                if (str["print line -".Length + 1]!= ' ')
                {
                    Console.WriteLine("Wrong symbol");
                    Console.ReadKey();
                    return;
                }
                if(str.IndexOf("-hor") != -1)
                {
                    direction = 'h';
                }
                else if (str.IndexOf("-ver") != 1)
                {
                    direction = 'v';
                }
                else
                {
                    Console.WriteLine("Wrong direction");
                    Console.ReadKey();
                    return;
                }
                //add lenght
                string len = str.Substring("print line -  -".Length, (str.IndexOf("-vert") != -1 ? str.IndexOf("-vert") : str.IndexOf("-hor"))-2 - "print line - -".Length);
                lenght = Convert.ToInt32(len);

                for(int i =0; i < lenght; i++)
                {
                   switch (direction)
                    {
                        case 'v':
                            Console.WriteLine(symbol);
                            break;
                        case 'h':
                            Console.Write(symbol);
                            break;
                    }
                }
                Console.WriteLine();
                        
                 
            }

            else
            {
                Console.WriteLine("Wrong command");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
