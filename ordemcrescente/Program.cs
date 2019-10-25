using System;

namespace ordemcrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            do{
            System.Console.WriteLine("digite um numero");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite um numero");
            num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite um numero");
            num3 = int.Parse(Console.ReadLine());

            if((num2<num1)&&(num3<num1)&&(num2<num3)){
                System.Console.WriteLine($"numero em ordem crescente {num2}, {num3}, {num1}");
            }else
            if((num1>num2)&&(num1<num3)){
                System.Console.WriteLine($"numero em ordem crescente {num2}, {num1}, {num3}");
            }else
            if((num1<num2)&&(num1<num3)&&(num3<num2)){
                System.Console.WriteLine($"numero em ordem crescente {num1}, {num3}, {num2}");
            }else
            if((num3<num2)&&(num2>num1)&&(num3<num1)){
                System.Console.WriteLine($"numero em ordem crescente {num3}, {num1}, {num2}");
            }else
            if((num3>num2)&&(num2>num1)){
                System.Console.WriteLine($"numero em ordem crescente {num1}, {num2}, {num3}");
            }else
            if((num1>num2)&&(num2>num3)){
                System.Console.WriteLine($"numero em ordem crescente {num3}, {num2}, {num1}");
            }
            }while((num1==num2)||(num1==num3)||(num2==num3));
            
            


            
            
            


            
        }
    }
}

