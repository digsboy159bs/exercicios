using System;

namespace Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            System.Console.WriteLine("digite um numero");
            num = int.Parse(Console.ReadLine());
            
            for(int i=1  ; (i<num); i+=2){
                
                Console.Write(i + "   ");
            }
        }
    }
}
