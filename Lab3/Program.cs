using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool egalitate = SuntEgale(1.23, 1.24, 0.1);


            int n, k;

            int x = 31;
            //TestTransmiterePrinValoare(x);

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            double minim = Minim(n, k);

            var min = Math.Min(n, k);
            var radacina = Math.Sqrt(n);

            

            double aranjamente = Aranjamente(n, n-k);
            double combinari = aranjamente / Factorial(k);

            Console.WriteLine(aranjamente);
            Console.WriteLine(combinari);

            //StackOverflow();
        }
        static void StackOverflow() {
            StackOverflow();
        }
        static void TestTransmiterePrinValoare(int abc)
        {
            abc = abc + 1;
        }

        static bool SuntEgale(double a, double b, double tolerance)
        {
            if (Math.Abs(a-b)<tolerance)
            {
                return true;
            }

            return false;
        }

        static void MaiMare(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine("a mai mic decat b");
                return;
            }
                if (b < a)
                {
                    Console.WriteLine("b mai mic decat a");
                    return;
                }

            Console.WriteLine("mai mici sau egale");
        }

        static double Minim(int a, int b)
        {
            if (a < b)
            {
                return a;
            }

            return b;
        }
        static double Aranjamente(int n, int k)
        {
            return Factorial(n) / Factorial(n-k);
        }
        static long Factorial(int numar)
        {
            long nFactorial = 1;
            for (int i = 1; i <= numar; i++)
            {
                nFactorial *= i;
            }

            return nFactorial;
        }
    } 
}
