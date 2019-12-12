using System;

namespace kahoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {10, 15 , 48},
                {56, 97, 77},
                {2, 100, 33}
            };
            foreach(var item in matrix){
                soma +=item;

            }
            System.Console.WriteLine(soma);
        }
    }
}
