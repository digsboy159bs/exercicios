using System;

namespace troca
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int A1;
            int B1;

            System.Console.WriteLine("digite A");
            A = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite B");
            B = int.Parse(Console.ReadLine());

            A1 = B;
            B1 = A;

            System.Console.WriteLine("o  valor de A é " + A1);
            System.Console.WriteLine("o  valor de B é " + B1);
        }
    }
}
