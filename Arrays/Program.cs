using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vect = new int[] { 5, 1, 3, 6, 2, 9, 4, 4 };

            Console.WriteLine("vectorul neordonat"); 
            AfiseazaVector(vect);

            SorteazaVector(vect);

            Console.WriteLine("vectorul ordonat");
            AfiseazaVector(vect);
        }
        private static void SorteazaVector(int[] vect)
        {
            bool dirty = true;
            while (dirty)
            {
                dirty = false;
                for (var i = 0; i < vect.Length - 1; i++)
                {
                    if (vect[i] > vect[i + 1])
                    {
                        int aux = vect[i];
                        vect[i] = vect[i + 1];
                        vect[i + 1] = aux;
                        dirty = true;
                    }
                }
            }
        }
        private static void AfiseazaVector(int[] vect)
        {
            for (var i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }
    }
}
