using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
             int num1 = 0;
            int num2 = 0;
            string oper;
        Console.WriteLine("digite o 1° numero:");
       num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("digite o 2° numero:");
         num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("digite o operador:");
        oper = Console.ReadLine();
       
         
         
        
       
        
       
          
        if(oper=="+") {
      Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
       }
       else
       if(oper== "-"){
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
       }
       else
       if(oper== "*") {
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
       }
      else
       if(oper=="/"){
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
      }
      else
      if(oper=="%"){
        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
      }
      else
      Console.WriteLine("operaçao invalida");
          

        }
    }
}
